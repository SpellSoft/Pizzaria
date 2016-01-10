using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Repository
{
    public class CategoriaRepositorio : DefaultRepositorio<Categoria>
    {
     
        public int GetIDCategoriaPorNome(string nome)
        {
            var result = entities.FirstOrDefault(c => c.Nome == nome);
            return result == null ? 0 : result.CategoriaID;
           
        }

        public string GetUltimoRegistro()
               => entities.OrderByDescending(c => c.CategoriaID).FirstOrDefault()?.Nome;
    }
}
