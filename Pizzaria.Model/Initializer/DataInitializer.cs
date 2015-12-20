using Pizzaria.Model.Data;
using Pizzaria.Model.Entity;
using System.Data.Entity;

namespace Pizzaria.Model.Initializer
{
    public class DataInitializer : DropCreateDatabaseAlways<_DbContext>
    {      
        protected override void Seed(_DbContext context)
        {
            context.Categoria.Add(new Categoria
            {
                Nome = "Cerveja"
            });
            context.Produto.Add(new Produto
            {
                CategoriaID = 1,
                Codigo = "200",
                Nome = "Kaiser",
                PrecoCompra = 10,
                PrecoVenda = 20,
                Estoque = new Estoque
                {
                    Gerenciar = true,
                    Quantidade = 50,
                    QuantidadeMaxima = 10,
                    QuantidadeMinima = 5,


                }
            });
            context.SaveChanges();
        }
    }
}
