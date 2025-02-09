using AutoMapper;
using TechShop.Domain.Base;
using TechShop.Domain.Entities;
using TechShop.Repository.BaseRepository;
using TechShop.Repository.Context;
using TechShop.Repository.Mapping;
using TechShop.Service.Services;
using TechShop.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json.Serialization;

namespace TechShop.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "TechShop";
                var username = "root";
                var password = "1234";
                var strCon = $"Server={server}; Port={port}; Database={database};" +
                             $"Uid={username}; Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, Usuario>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Fornecedor>, BaseRepository<Fornecedor>>();
            services.AddScoped<IBaseService<Fornecedor>, BaseService<Fornecedor>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Fornecedor, Fornecedor>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Categoria>, BaseRepository<Categoria>>();
            services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Categoria, Categoria>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Produto, Produto>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Cliente, Cliente>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Pedido>, BaseRepository<Pedido>>();
            services.AddScoped<IBaseService<Pedido>, BaseService<Pedido>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Pedido, Pedido>();
            }).CreateMapper());

            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestInsertFornecedor()
        {
            var sp = ConfigureServices();
            var fornecedorService = sp.GetService<IBaseService<Fornecedor>>();
            var fornecedor = new Fornecedor()
            {
                Nome = "TechSupply Solutions",
                Contato = "contato@techsupply.com.br",
                Endereco = "Avenida dos Computadores, 456"
            };

            var result = fornecedorService.Add<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
            Console.Write(JsonSerializer.Serialize(result));
        }

        public void TestInsertCliente()
        {
            var sp = ConfigureServices();
            var clienteService = sp.GetService<IBaseService<Cliente>>();
            var cidade = clienteService.Get<Cliente>().FirstOrDefault(c => c.Id >= 1);
            var cliente = new Cliente()
            {
                Nome = "Pedro",
                Email = "pedrinhu@gmail.com",
                Telefone = "18991222222",
                Endereco = "Rua Computação, 1902, Vale dos Computadores",
                DataCadastro = DateTime.Now,
                Documento = "222.222.222-11"
            };

            var result = clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertCategoria()
        {
            var sp = ConfigureServices();
            var categoriaService = sp.GetService<IBaseService<Categoria>>();
            var categoria = new Categoria()
            {
                Nome = "Hardware",
                Descricao = "Componentes de hardware como processadores, placas de vídeo, memórias e outros."
            };

            var result = categoriaService.Add<Categoria, Categoria, CategoriaValidator>(categoria);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertProduto()
        {
            var sp = ConfigureServices();
            var categoriaService = sp.GetService<IBaseService<Categoria>>();
            var categoria = categoriaService.Get<Categoria>().FirstOrDefault(c => c.Id >= 1);
            var fornecedorService = sp.GetService<IBaseService<Fornecedor>>();
            var fornecedor = fornecedorService.Get<Fornecedor>().FirstOrDefault(c => c.Id >= 1);
            var produtoService = sp.GetService<IBaseService<Produto>>();
            var produto = new Produto()
            {
                Nome = "Placa de Vídeo NVIDIA RTX 3080",
                Descricao = "Placa de vídeo com 10 GB de memória GDDR6X",
                Modelo = "RTX 3080",
                Preco = 4500f,
                Fabricante = "NVIDIA",
                AnoLancamento = 2020,
                QuantidadeEstoque = 100,
                Categoria = categoria,
                Fornecedor = fornecedor
            };

            var result = produtoService.Add<Produto, Produto, ProdutoValidator>(produto);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario()
            {
                Nome = "Jorge",
                Senha = "123",
                Login = "jorgebom",
                Email = "teste.com",
                DataCadastro = DateTime.Now,
                DataLogin = DateTime.Now,
                Ativo = true
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestInsertPedido()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = usuarioService.Get<Usuario>().FirstOrDefault(c => c.Id >= 1);
            var clienteService = sp.GetService<IBaseService<Cliente>>();
            var cliente = clienteService.Get<Cliente>().FirstOrDefault(d => d.Id >= 1);
            var produtoService = sp.GetService<IBaseService<Produto>>();
            var produto = produtoService.Get<Produto>().FirstOrDefault(e => e.Id >= 1);
            var pedidoService = sp.GetService<IBaseService<Pedido>>();
            var pedido = new Pedido()
            {
                DataPedido = DateTime.Now,
                ValorTotal = (float)(5 * produto.Preco),
                Cliente = cliente,
                Usuario = usuario
            };

            pedido.Itens.Add(
            new ItensPedido
            {
                Produto = produto,
                Quantidade = 5,
                PrecoUnitario = (float)produto.Preco,
                Pedido = pedido
            });

            var result = pedidoService.Add<Pedido, Pedido, PedidoValidator>(pedido);
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,  // Permite ciclos de referência
                MaxDepth = 64  // Opcional: Ajusta a profundidade máxima de serialização
            };

            Console.WriteLine(JsonSerializer.Serialize(result, options));
        }

        [TestMethod]
        public void TestSelectFornecedor()
        {
            var sp = ConfigureServices();
            var CidadeServices = sp.GetService<IBaseService<Fornecedor>>();
            var result = CidadeServices.Get<Fornecedor>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCliente()
        {
            var sp = ConfigureServices();
            var ClienteServices = sp.GetService<IBaseService<Cliente>>();
            var result = ClienteServices.Get<Cliente>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectCategoria()
        {
            var sp = ConfigureServices();
            var GrupoServices = sp.GetService<IBaseService<Categoria>>();
            var result = GrupoServices.Get<Categoria>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectProduto()
        {
            var sp = ConfigureServices();
            var ProdutoServices = sp.GetService<IBaseService<Produto>>();
            var result = ProdutoServices.Get<Produto>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectUsuario()
        {
            var sp = ConfigureServices();
            var UsuarioServices = sp.GetService<IBaseService<Usuario>>();
            var result = UsuarioServices.Get<Usuario>();
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectPedido()
        {
            var sp = ConfigureServices();
            var PedidoServices = sp.GetService<IBaseService<Pedido>>();
            var result = PedidoServices.Get<Pedido>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}
