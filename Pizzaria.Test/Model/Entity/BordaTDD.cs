using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Test.Model.Entity
{
    public class BordaTDD
    {
        public void Borda_Teste_Atribuicao()
        {
            var bor = new Borda
            {
                Descricao = "xxvxvcvcvcvcvcv sddfss ",
                Nome = "Catupiry",
                Preco = 9
            };
            IList<ValidationResult> erros = new List<ValidationResult>();
            if (!Validator.TryValidateObject(bor, new ValidationContext(bor), erros, true))
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
