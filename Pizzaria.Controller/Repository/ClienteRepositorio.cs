using Pizzaria.Model.Entity;
using Pizzaria.Model.ModelView;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System;

namespace Pizzaria.Controller.Repository
{
    public class ClienteRepositorio : DefaultRepositorio<Cliente>
    {
        public List<ClientePesquisaViewModel> ListarViewModel()
        {
            return entities.Select(cli =>
            new ClientePesquisaViewModel
            {
                ClienteID = cli.ClienteID,
                Nome = cli.Nome,
                Cidade = cli.Endereco.Cidade.Nome,
                Telefone = cli.Contato.Celular == null ? cli.Contato.Fixo : cli.Contato.Celular
            }).ToList();
        }

        public List<ClientePesquisaViewModel> PesquisaPorNome(string txt = "")
        {
            return entities.Select(cli =>
           new ClientePesquisaViewModel
           {
               ClienteID = cli.ClienteID,
               Nome = cli.Nome,
               Cidade = cli.Endereco.Cidade.Nome,
               Telefone = cli.Contato.Celular == null ? cli.Contato.Fixo : cli.Contato.Celular
           }).Where(c => c.Nome.Contains(txt)).ToList();
        }
        public override bool Deletar(int? id)
        {
            Cliente cliente = entities.Include(c => c.Contato).Include(c=>c.Endereco).FirstOrDefault(c => c.ClienteID == id);
            entities.Remove(cliente);
            return Confirmar();
        }

      
    }
}
