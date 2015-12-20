using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Model.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Test
{
    [TestClass]
    public class ProdutoTeste
    {
        [TestMethod]
        public void Produto_teste_Atribuicao()
        {
            var prod = new Produto();
            prod.ProdutoID = 1;
            prod.CategoriaID = 1;
            prod.Codigo = "1234567891234";
            prod.Nome = "Kaiser";
            prod.PrecoCompra = 10001;
            prod.PrecoVenda = 10009;
            IList<ValidationResult> erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(prod, new ValidationContext(prod), erros, true))
            {

               //erro
               
            }
            else
            {
                //valido
            }
        }
    }
}
