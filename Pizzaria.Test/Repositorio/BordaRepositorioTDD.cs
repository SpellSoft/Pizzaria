using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Test.Repositorio
{
    [TestClass]
    public class BordaRepositorioTDD
    {


        [TestMethod]
        public void BordaRepositorio_Teste_Salvar()
        {
            var bor = new Borda
            {
                Descricao = "xxvxvcvcvcvcvcv sddfss ",
                Nome = "Catupiry",
                Preco = 9
            };
            var controller = new BordaRepositorio();
            Assert.AreEqual(true, controller.Salvar(bor));
        }
    }
}
