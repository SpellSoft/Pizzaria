using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Repository
{
    public class ComplementoRepositorio : DefaultRepositorio<Complemento>
    {
        public override bool Salvar(Complemento entities)
        {
            return base.Salvar(entities);
        }
    }
}
