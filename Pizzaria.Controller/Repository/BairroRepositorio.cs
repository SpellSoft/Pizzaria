using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Repository
{
    public class BairroRepositorio : DefaultRepositorio<Bairro>
    {
        public int? ListarIdPorNome(string name)
        {
            return base.Listar().FirstOrDefault(c => c.Nome == name)?.BairroID;
        }
    }
}
