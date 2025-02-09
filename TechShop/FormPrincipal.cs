using Microsoft.VisualBasic.Logging;
using ReaLTaiizor.Forms;
using TechShop.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using TechShop.App.Infra;
using TechShop.App.Cadastros;
using TechShop.App.Outros;
namespace TechShop
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuario Usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUsuario.Text = $"Usu�rio: {Usuario.Nome}";
                }
            }
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFornecedor>();
        }

        private void FecharForm(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void usu�riosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuario>();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCategoria>();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProduto>();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCliente>();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPedido>();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}

