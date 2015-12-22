using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Repository
{
    public class ProdutoRepositorio : DefaultRepositorio<Produto>
    {
        public override bool Salvar(Produto entities)
        {
            return base.Salvar(entities);
        }
    }
}
