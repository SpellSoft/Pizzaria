using Pizzaria.Model.Entity;
using Pizzaria.Model.ModelView;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Controller.Repository
{
    public class ProdutoRepositorio : DefaultRepositorio<Produto>
    {
        public override bool Salvar(Produto entities)
        {
            return base.Salvar(entities);
        }
        public override Produto GetPeloID(int id)
        {
            return base.GetPeloID(id);
        }
        public override bool Editar(Produto entities)
        {
            return base.Editar(entities);
        }
        public override List<Produto> Listar()
        {
            return base.Listar();
        }
        public List<ProdutoPesquisaViewModel> ListarPesquisa()
        {
            return (from prod in Listar()
                    select new ProdutoPesquisaViewModel
                    {
                        ProdutoID = prod.ProdutoID,
                        Nome = prod.Nome,
                        Categoria = prod.Categoria.Nome,
                        Código = prod.Codigo,
                        PrecoVenda = prod.PrecoVenda
                    }).ToList();
        }
    }
}
