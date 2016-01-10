using Pizzaria.Model.Entity;
using System.Linq;

namespace Pizzaria.Controller.Repository
{
    public class ComplementoRepositorio : DefaultRepositorio<Complemento>
    {
        public Complemento GetUltimoResgistro()
        {
            return entities.OrderByDescending(c => c.ComplementoID).FirstOrDefault();
        }

    }
}
