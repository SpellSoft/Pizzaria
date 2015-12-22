using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Controller;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System.Collections.Generic;

namespace Pizzaria.Test.Repositorio
{
    [TestClass]
    public class ProdutoControllerTDD
    {
        [TestMethod]
        public void DefaultRepository_Test_Create()
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
                , Categoria = new Categoria { Nome = "XXX" },
                Estoque = new Estoque { Gerenciar = true, Quantidade = 99, QuantidadeMaxima = 50, QuantidadeMinima = 20 },
                CategoriaID = 1,
                
            };
            Assert.AreEqual(true,repo.Salvar(prod));
        }

    }
}
