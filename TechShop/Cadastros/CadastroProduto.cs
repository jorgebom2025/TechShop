using TechShop.App.Base;
using TechShop.App.Models;
using TechShop.Domain.Base;
using TechShop.Domain.Entities;
using TechShop.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechShop.App.Cadastros
{
    public partial class CadastroProduto : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Produto> _produtoService;
        private readonly IBaseService<Fornecedor> _fornecedorService;
        private readonly IBaseService<Categoria> _categoriaService;
        private List<ProdutoModel>? produtos;
        #endregion

        #region Construtor
        public CadastroProduto(IBaseService<Produto> produtoService, IBaseService<Categoria> categoriaService, IBaseService<Fornecedor> fornecedorService)
        {
            _produtoService = produtoService;
            _categoriaService = categoriaService;
            _fornecedorService = fornecedorService;
            InitializeComponent();
            CarregarCombo();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Produto produto)
        {
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Modelo = txtModelo.Text;
            if (float.TryParse(txtPreco.Text, out float preco))
            {
                produto.Preco = preco;
            }
            produto.Fabricante = txtFabricante.Text;
            if (int.TryParse(txtAnoLancamento.Text, out int ano))
            {
                produto.AnoLancamento = ano;
            }
            if (int.TryParse(txtQuantidadeEstoque.Text, out int quantidade))
            {
                produto.QuantidadeEstoque = quantidade;
            }

            if (int.TryParse(cboCategoria.SelectedValue.ToString(), out int idCategoria))
            {
                var categoria = _categoriaService.GetById<Categoria>(idCategoria);
                produto.Categoria = categoria;
            }
            if (int.TryParse(cboFornecedor.SelectedValue.ToString(), out int idFornecedor))
            {
                var fornecedor = _fornecedorService.GetById<Fornecedor>(idFornecedor);
                produto.Fornecedor = fornecedor;
            }
        }

        private void CarregarCombo()
        {
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.DataSource = _categoriaService.Get<CategoriaModel>().ToList();
            cboFornecedor.ValueMember = "Id";
            cboFornecedor.DisplayMember = "Nome";
            cboFornecedor.DataSource = _fornecedorService.Get<FornecedorModel>().ToList();
        }
        #endregion

        #region Eventos CRUD
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var produto = _produtoService.GetById<Produto>(id);
                        PreencheObjeto(produto);
                        produto = _produtoService.Update<Produto, Produto, ProdutoValidator>(produto);
                    }
                }
                else
                {
                    var produto = new Produto();
                    PreencheObjeto(produto);
                    _produtoService.Add<Produto, Produto, ProdutoValidator>(produto);
                }
                tabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"TechShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Excluir(int id)
        {
            try
            {
                _produtoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"TechShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {

            produtos = _produtoService.Get<ProdutoModel>().ToList();
            dgvConsulta.DataSource = produtos;
            dgvConsulta.Columns["Id"].DisplayIndex = 0;
            dgvConsulta.Columns["Nome"].DisplayIndex = 1;
            dgvConsulta.Columns["Descricao"].DisplayIndex = 2;
            dgvConsulta.Columns["Modelo"].DisplayIndex = 3;
            dgvConsulta.Columns["Preco"].DisplayIndex = 4;
            dgvConsulta.Columns["Fabricante"].DisplayIndex = 5;
            dgvConsulta.Columns["AnoLancamento"].DisplayIndex = 6;
            dgvConsulta.Columns["QuantidadeEstoque"].DisplayIndex = 7;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
            txtModelo.Text = linha?.Cells["Modelo"].Value.ToString();
            txtPreco.Text = linha?.Cells["Preco"].Value.ToString();
            txtFabricante.Text = linha?.Cells["Fabricante"].Value.ToString();
            txtAnoLancamento.Text = linha?.Cells["AnoLancamento"].Value.ToString();
            txtQuantidadeEstoque.Text = linha?.Cells["QuantidadeEstoque"].Value.ToString();
            cboCategoria.SelectedValue = linha?.Cells["IdCategoria"].Value;
            cboFornecedor.SelectedValue = linha?.Cells["IdFornecedor"].Value;
        }
        #endregion

        private void txtEdicao_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidadeEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
