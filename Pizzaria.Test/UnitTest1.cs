using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Model.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var prod = new Produto();
            prod.ProdutoID = 1;
            prod.CategoriaID = 1;
            prod.Codigo = "1234567891234";
            prod.Gerenciar = true;
            prod.Nome = "Kaiser";
            prod.PrecoCompra = 10.0;
            prod.PrecoVenda = 9;
            IList<ValidationResult> erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(prod, new ValidationContext(prod), erros, true))
            {

                var errosMessage = "";
                int cont = 0;
             
                foreach (var c in erros)
                {
                    cont++;
                    errosMessage += c.ErrorMessage + "\n";
                    var txt = c.MemberNames;
                   
                }
               
            }
            else
            {
               
            }
        }
    }
}
