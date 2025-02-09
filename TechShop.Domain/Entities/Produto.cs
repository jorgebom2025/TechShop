using TechShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public Produto() { }
        public Produto(int id, string nome, string descricao, string modelo, float preco, string fabricante, int anolancamento, int quantidadeestoque, Fornecedor fornecedor, Categoria categoria) : base(id)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Modelo = modelo;
            this.Preco = preco;
            this.Fabricante = fabricante;
            this.AnoLancamento = anolancamento;
            this.QuantidadeEstoque = quantidadeestoque;
            this.Fornecedor = fornecedor;
            this.Categoria = categoria;
        }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public float Preco { get; set; }
        public string Fabricante { get; set; }
        public int AnoLancamento { get; set; }
        public int QuantidadeEstoque { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
