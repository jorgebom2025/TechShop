using TechShop.Domain.Entities;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace TechShop.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        DateTime data = new DateTime(2025, 01, 01, 01, 0, 0);
        [TestMethod]
        public void TestFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor(1, "TechSupply Solutions", "contato@techsupply.com.br", "Avenida dos Computadores, 456");
            Debug.Write(JsonSerializer.Serialize(fornecedor));
            Assert.AreEqual(fornecedor.Nome, "TechSupply Solutions");
            Assert.AreEqual(fornecedor.Contato, "contato@techsupply.com.br");
            Assert.AreEqual(fornecedor.Endereco, "Avenida dos Computadores, 456");
        }
        [TestMethod]
        public void TestCategoria()
        {
            Categoria categoria = new Categoria(1, "Hardware", "Componentes de hardware como processadores, placas de vídeo, memórias e outros.");
            Debug.Write(JsonSerializer.Serialize(categoria));
            Assert.AreEqual(categoria.Nome, "Hardware");
            Assert.AreEqual(categoria.Descricao, "Componentes de hardware como processadores, placas de vídeo, memórias e outros.");
        }
        [TestMethod]
        public void TestProduto()
        {
            Fornecedor fornecedor = new Fornecedor(1, "TechSupply Solutions", "contato@techsupply.com.br", "Avenida dos Computadores, 456");
            Categoria categoria = new Categoria(1, "Hardware", "Componentes de hardware como processadores, placas de vídeo, memórias e outros.");
            Produto produto = new Produto(
                1, 
                "Placa de Vídeo NVIDIA RTX 3080",
                "Placa de vídeo com 10 GB de memória GDDR6X",
                "RTX 3080", 
                4500, 
                "NVIDIA",
                2020, 
                50,
                fornecedor, 
                categoria 
            );
            Debug.Write(JsonSerializer.Serialize(produto));
            Assert.AreEqual(produto.Nome, "Placa de Vídeo NVIDIA RTX 3080");
            Assert.AreEqual(produto.Descricao, "Placa de vídeo com 10 GB de memória GDDR6X");
            Assert.AreEqual(produto.Modelo, "RTX 3080");
            Assert.AreEqual(produto.Preco, 4500);
            Assert.AreEqual(produto.Fabricante, "NVIDIA");
            Assert.AreEqual(produto.AnoLancamento, 2020);
            Assert.AreEqual(produto.QuantidadeEstoque, 50);
            Assert.AreEqual(produto.Fornecedor, fornecedor);
            Assert.AreEqual(produto.Categoria, categoria);
        }
        [TestMethod]
        public void TestUsuario()
        {
            Usuario usuario = new Usuario(1, "Jorge Bom", "12345678", "Jorge", "teste@gmail.com", data, data, true);
            Debug.Write(JsonSerializer.Serialize(usuario));
            Assert.AreEqual(usuario.Nome, "Jorge Bom");
            Assert.AreEqual(usuario.Senha, "12345678");
            Assert.AreEqual(usuario.Login, "Jorge");
            Assert.AreEqual(usuario.Email, "teste@gmail.com");
            Assert.AreEqual(usuario.DataCadastro, data);
            Assert.AreEqual(usuario.DataLogin, data);
            Assert.AreEqual(usuario.Ativo, true);
        }
        [TestMethod]
        public void TestCliente()
        {
            Cliente cliente = new Cliente(1, "João", "joaozinho@gmail.com", "1811111111", "Rua Pedro Cavalo, 709, Portal", data, "111.222.333.44");
            Debug.Write(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "João");
            Assert.AreEqual(cliente.Email, "joaozinho@gmail.com.com");
            Assert.AreEqual(cliente.Telefone, "1811111111");
            Assert.AreEqual(cliente.Endereco, "Rua Pedro Cavalo, 709, Portal");
            Assert.AreEqual(cliente.DataCadastro, data);
            Assert.AreEqual(cliente.Documento, "111.222.333.44");
        }

        public void TestDataPedido()
        {
            Fornecedor fornecedor = new Fornecedor(1, "TechSupply Solutions", "contato@techsupply.com.br", "Avenida dos Computadores, 456");
            Categoria categoria = new Categoria(1, "Hardware", "Componentes de hardware como processadores, placas de vídeo, memórias e outros.");
            Produto produto = new Produto(
                1, 
                "Placa de Vídeo NVIDIA RTX 3080",
                "Placa de vídeo com 10 GB de memória GDDR6X", 
                "RTX 3080", 
                4500, 
                "NVIDIA", 
                2020,
                50, 
                fornecedor, 
                categoria 
            );
            List<ItensPedido> Itens = new List<ItensPedido>();
            ItensPedido itensPedido = new ItensPedido(
                1, 
                2, 
                4500, 
                produto, 
                null 
            );
            Itens.Add(itensPedido);
            Assert.AreEqual(itensPedido.Quantidade, 2);
            Assert.AreEqual(itensPedido.PrecoUnitario, 4500);
            Assert.AreEqual(itensPedido.Produto, produto);
            Pedido pedido = new Pedido();
            Assert.AreEqual(pedido.ValorTotal, 9000);
        }
    }
}