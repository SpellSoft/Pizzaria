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
        public override bool Salvar(Sabor entities)
        {
            return base.Salvar(entities);
        }
        public int? GetIDCategoriaPorNome(string nome)
        {
            var result = entity.FirstOrDefault(c => c.Nome == nome);
            return result?.SaborID;

        }
    }
}
