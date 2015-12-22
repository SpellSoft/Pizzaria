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
        public override List<Categoria> Listar()
        {
            return base.Listar();
        }
        public override bool Salvar(Categoria entities)
        {
            return base.Salvar(entities);
        }
    }
}
