using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Controller
{
    public class ProdutoController : DefaultRepositorio<Produto>
    {
      
        public override List<Produto> Listar()
        {           
            return base.Listar();
        }
        public override bool Salvar(Produto entities)
        {
            return base.Salvar(entities);
        }

    }
}
