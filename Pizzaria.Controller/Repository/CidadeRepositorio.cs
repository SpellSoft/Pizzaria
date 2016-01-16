using System;
using Pizzaria.Model.Entity;
using System.Linq;
namespace Pizzaria.Controller.Repository
{
    public class CidadeRepositorio : DefaultRepositorio<Cidade>
    {
        public int? ListarIdPorNome(string text)
        {
            return entities.FirstOrDefault(c=>c.Nome.ToLower() == text.ToLower())?.CidadeID;
        }

        public string GetUltimoRegistro()
               => entities.OrderByDescending(c => c.CidadeID).FirstOrDefault()?.Nome;
    }
}
