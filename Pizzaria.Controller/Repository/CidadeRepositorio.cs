using Pizzaria.Model.Entity;
using System.Linq;
using System.Collections.Generic;

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

        public List<Cidade> PesquisarPorNome(string text)
        {
            return entities.Where(c=>c.Nome.ToLower().Contains(text)).ToList();
        }
    }
}
