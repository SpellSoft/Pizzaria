﻿using MySql.Data.Entity;
using Pizzaria.Model.Entity;
using Pizzaria.Model.Initializer;
using System.Configuration;
using System.Data.Entity;
namespace Pizzaria.Model.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class _DbContext : DbContext
    {
        public _DbContext() : base(ConfigurationManager.ConnectionStrings["Pizzaria"].ConnectionString)
        {
            Database.SetInitializer<_DbContext>(new DataInitializer());
        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Sabor> Sabor { get; set; }
        public DbSet<Complemento> Complemento { get; set; }
        public DbSet<Borda> Borda { get; set; }
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Logradouro> Logradouro { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasRequired(c => c.Contato)
                .WithRequiredPrincipal().WillCascadeOnDelete(true);

            modelBuilder.Entity<Cliente>().HasRequired(c => c.Endereco)
              .WithRequiredPrincipal().WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}
