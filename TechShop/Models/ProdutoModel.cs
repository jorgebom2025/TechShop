using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.App.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Modelo{ get; set; }
        public float Preco { get; set; }
        public string Fabricante { get; set; }
        public int AnoLancamento { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int IdFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}
