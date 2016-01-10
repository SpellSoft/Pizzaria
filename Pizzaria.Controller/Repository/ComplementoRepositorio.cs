using Pizzaria.Model.Entity;
using System.Linq;

namespace Pizzaria.Controller.Repository
{
    public class ComplementoRepositorio : DefaultRepositorio<Complemento>
    {
        public override bool Salvar(Complemento entities)
        {
            return base.Salvar(entities);
        }
        public Complemento GetUltimoResgistro()
        {
            return entities.OrderByDescending(c => c.ComplementoID).FirstOrDefault();
        }

    }
}
