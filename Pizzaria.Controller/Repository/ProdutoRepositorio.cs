using Pizzaria.Model.Entity;
using Pizzaria.Model.ModelView;
using System.Collections.Generic;
using System.Linq;
using System;

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
                    }).Where(c=>c.Nome.ToLower().Contains(nome)).ToList();
           
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
    }
}
