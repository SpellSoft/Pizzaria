using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizzaria.Model.Entity;
using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Test.Model.Entity
{
    /// <summary>
    /// Summary description for Complemeto
    /// </summary>
    [TestClass]
    public class ComplementoTDD
    {
      

        [TestMethod]
        public void Complemento_Test_Atribuicao()
        {
            var com = new Complemento
            {
                 Descricao = "hsdhhs hsbd hxhb   h bhsb hsb hbsh sh b",
                  Preco = 5,
                    SaborID = 1
            };
            IList<ValidationResult> erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(com, new ValidationContext(com), erros, true))
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
