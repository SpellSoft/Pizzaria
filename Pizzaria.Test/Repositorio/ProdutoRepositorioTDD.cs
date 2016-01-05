using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Controller;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.Model.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Pizzaria.Test.Repositorio
{
    [TestClass]
    public class ProdutoRepositorioTDD
    {
        [TestMethod]
        public void DefaultRepository_Pizza_ProdutoCreate()
        {
            var repo = new ProdutoRepositorio();
            var prod = new Produto
            {
                Nome = "Skol beats",
                Codigo = "200",
                /*ComplementoID = 1,*/
                Descricao = "hshbsdhbhs hjbsdh hb  sbd hsbdh bshd hs hb",
                PrecoCompra = 10,
                PrecoVenda = 12,
                Complemento = new List<Complemento>
                       {
                              new Complemento { Descricao = "jdnfmdnfd", Preco = 9, Sabor = new Sabor { Nome="Picanha" } }
                       }
                ,
                Categoria = new Categoria { Nome = "XXX" },
                Estoque = new Estoque { Gerenciar = true, Quantidade = 99, QuantidadeMaxima = 50, QuantidadeMinima = 20 },
                CategoriaID = 1,

            };
            Assert.AreEqual(true, repo.Salvar(prod));
        }
        [TestMethod]
        public void DefaultRepository_Outros_ProdutoCreate()
        {

            try
            {
                var repo = new ProdutoRepositorio();
                var prod = new Produto
                {
                    Nome = "Skol beats",
                    Codigo = "200",
                    Descricao = "hshbsdhbhs hjbsdh hb  sbd hsbdh bshd hs hb",
                    PrecoCompra = 10,
                    PrecoVenda = 12,
                    CategoriaID = 1,
                    BordaID = null,
                    SaborID = null,



                };
                Assert.AreEqual(true, repo.Salvar(prod));

            }
            catch (Exception error)
            {
                Assert.Fail(error.Message);
            }

        }
        [TestMethod]
        public void DefaultRepository_Outros_ProdutoUpdateWithEstoque()
        {
            try
            {
                var repo = new ProdutoRepositorio();
                Produto prod = repo.GetPeloID(18);
                prod.Estoque = new Estoque
                {
                    ProdutoID = 18,
                    Gerenciar = true,
                    Quantidade = 10,
                    QuantidadeMinima = 50,
                    QuantidadeMaxima = 100
                };

                Assert.AreEqual(true, repo.Editar(prod));

            }
            catch (Exception error)
            {
                Assert.Fail(error.Message);
            }

        }
        [TestMethod]
        public void ProdutoRepositorio_Produto_GetProdutoPesquisaViewModel()
        {

            try
            {
                var repositorioRepositorio = new ProdutoRepositorio();
                var com = from prod in repositorioRepositorio.Listar()
                          select new ProdutoPesquisaViewModel
                          {
                              ProdutoID = prod.ProdutoID,
                              Nome = prod.Nome,
                              Categoria = prod.Categoria.Nome,
                              Código = prod.Codigo,
                              PrecoVenda = prod.PrecoVenda
                          };
                Assert.AreNotEqual(0, com.Count());

            }
            catch (Exception error)
            {
                Assert.Fail(error.Message);
            }

        }

    }
}
