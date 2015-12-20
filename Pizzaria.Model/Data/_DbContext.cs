using MySql.Data.Entity;
using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]    
    public class _DbContext : DbContext
    {
        public _DbContext(): base(ConfigurationManager.ConnectionStrings["Pizzaria"].ConnectionString)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

    }
}
