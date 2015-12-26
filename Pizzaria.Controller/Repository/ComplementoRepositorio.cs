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
            var complemento = entity.OrderByDescending(c => c.ComplementoID).FirstOrDefault();
            return complemento;
        }
    }
}
