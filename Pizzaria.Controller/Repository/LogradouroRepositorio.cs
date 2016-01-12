using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Repository
{
    public class LogradouroRepositorio : DefaultRepositorio<Logradouro>
    {
        public int? ListarIdPorNome(string text)
        {
            return entities.FirstOrDefault(c=>c.Nome == text)?.LogradouroID;
        }
    }
}
