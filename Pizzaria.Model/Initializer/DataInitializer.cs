using Pizzaria.Model.Data;
using Pizzaria.Model.Entity;
using System.Collections.Generic;
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
             context.SaveChanges();
            context.Sabor.Add(new Sabor
            {
                Nome = "Portuguesa"
            });
            context.SaveChanges();
            context.Complemento.Add(new Complemento
            {

                Descricao = "xxxxxxxxxxxxxxxx",
                Preco = 8,
                SaborID = 1


            });
            context.SaveChanges();
            context.Produto.Add(new Produto
            {
                CategoriaID = 1,
                Codigo = "200",
                Nome = "Kaiser",
                PrecoCompra = 10,
                PrecoVenda = 20,
                ComplementoID = 1,               
                Estoque = new Estoque
                {
                    Gerenciar = true,
                    Quantidade = 50,
                    QuantidadeMaxima = 10,
                    QuantidadeMinima = 5,


                },
                Descricao = "esse produto é feito de pizza",





            });
            context.SaveChanges();
        }
    }
}
