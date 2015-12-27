using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Controller.Repository
{
    public class BordaRepositorio : DefaultRepositorio<Borda>
    {
        public override List<Borda> Listar()
        {
            return base.Listar();
        }
        public override bool Salvar(Borda entities)
        {
            return base.Salvar(entities);
        }
        public int getIDPorNome(string nome)
        {
          var result =  entity.FirstOrDefault(c => c.Nome == nome);
            return result == null ? 0 : result.BordaID;
        }
    }
}
