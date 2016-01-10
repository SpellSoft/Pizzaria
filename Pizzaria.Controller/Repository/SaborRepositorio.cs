using Pizzaria.Model.Entity;
using System.Linq;

namespace Pizzaria.Controller.Repository
{
    public class SaborRepositorio : DefaultRepositorio<Sabor>
    {
       
        public int? GetIDCategoriaPorNome(string nome)
        {
            var result = entities.FirstOrDefault(c => c.Nome == nome);
            return result?.SaborID;
        }
        public string GetUltimoRegistro()
                      => entities.OrderByDescending(c => c.SaborID).FirstOrDefault()?.Nome;
    }
}
