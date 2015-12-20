using MySql.Data.Entity;
using Pizzaria.Model.Entity;
using Pizzaria.Model.Initializer;
using System.Configuration;
using System.Data.Entity;

namespace Pizzaria.Model.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]    
    public class _DbContext : DbContext
    {
        public _DbContext(): base(ConfigurationManager.ConnectionStrings["Pizzaria"].ConnectionString)
        {
            Database.SetInitializer<_DbContext>(new DataInitializer());
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

    }
}
