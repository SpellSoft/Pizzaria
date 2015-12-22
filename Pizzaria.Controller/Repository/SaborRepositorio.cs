using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Repository
{
    public class SaborRepositorio : DefaultRepositorio<Sabor>
    {
        public override List<Sabor> Listar()
        {
            return base.Listar();
        }
    }
}
