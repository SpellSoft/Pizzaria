using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Pizzaria.Test.Model.Entity
{
    [TestClass]
    public class EstoqueTDD
    {
       
        [TestMethod]
        public void Estoque_teste_Atribuicao()
        {
            var estoque = new Estoque();
            estoque.Gerenciar = true;
            estoque.Quantidade = -1;
            estoque.QuantidadeMinima = 20;
            estoque.QuantidadeMaxima = 21;
            estoque.ProdutoID = 1;
            IList<ValidationResult> erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(estoque, new ValidationContext(estoque), erros, true))
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
