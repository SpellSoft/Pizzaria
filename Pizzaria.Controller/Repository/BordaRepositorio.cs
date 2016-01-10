using Pizzaria.Model.Entity;
using System.Linq;

namespace Pizzaria.Controller.Repository
{
    public class BordaRepositorio : DefaultRepositorio<Borda>
    {
       
        public int getIDPorNome(string nome)
        {
          var result =  entities.FirstOrDefault(c => c.Nome == nome);
            return result == null ? 0 : result.BordaID;
        }
        public string GetUltimoRegistro()
                      => entities.OrderByDescending(c => c.BordaID).FirstOrDefault()?.Nome;
    }
}
