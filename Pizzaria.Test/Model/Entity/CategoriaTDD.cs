using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Test.Model.Entity
{
    [TestClass]
    public class CategoriaTDD
    {
        [TestMethod]
        public void Categoria_Test_Atribuicao()
        {
            var categori = new Categoria();
            categori.Nome = "leite";
            IList<ValidationResult> erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(categori, new ValidationContext(categori), erros, true))
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
