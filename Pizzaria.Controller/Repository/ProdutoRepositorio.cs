using Pizzaria.Model.Entity;
using Pizzaria.Model.ModelView;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Pizzaria.Controller.Repository
{
    public class ProdutoRepositorio : DefaultRepositorio<Produto>
    {
        public override bool Deletar(int? id)
        {
            var produto = entities.Include(c => c.Complemento).Include(c => c.Estoque).FirstOrDefault(c => c.ProdutoID == id);
            entities.Remove(produto);
            return Confirmar();
        }
        public List<ProdutoPesquisaViewModel> ListarPesquisa(string nome = "")
        {
            return (from prod in Listar()
                    select new ProdutoPesquisaViewModel
                    {
                        ProdutoID = prod.ProdutoID,
                        Nome = prod.Nome,
                        Categoria = prod.Categoria.Nome,
                        Código = prod.Codigo,
                        PrecoVenda = prod.PrecoVenda
                    }).Where(c => c.Nome.ToLower().Contains(nome)).ToList();

        }

        public object ListarPorCodigo(string code = "")
        {

            return (from prod in Listar()
                    select new ProdutoPesquisaViewModel
                    {
                        ProdutoID = prod.ProdutoID,
                        Nome = prod.Nome,
                        Categoria = prod.Categoria.Nome,
                        Código = prod.Codigo,
                        PrecoVenda = prod.PrecoVenda
                    }).Where(c => c.Código.ToLower().Contains(code)).ToList();
        }

        public object ListarPorCategoria(string category)
        {

            return (from prod in Listar()
                    select new ProdutoPesquisaViewModel
                    {
                        ProdutoID = prod.ProdutoID,
                        Nome = prod.Nome,
                        Categoria = prod.Categoria.Nome,
                        Código = prod.Codigo,
                        PrecoVenda = prod.PrecoVenda
                    }).Where(c => c.Categoria.ToLower().Contains(category)).ToList();
        }

        public Produto GetPeloCodigo(string codigo)
        {
            return entities.Include(c => c.Estoque)
                                .Include(c => c.Categoria)
                                .Include(c => c.Borda)
                                .Include(c => c.Sabor).
                                 Include(c=>c.Complemento)                            
                                .FirstOrDefault(c => c.Codigo.ToLower()
                                == codigo.ToLower());
        }
    }
}
