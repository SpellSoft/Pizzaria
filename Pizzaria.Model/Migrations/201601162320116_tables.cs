namespace Pizzaria.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bairro",
                c => new
                    {
                        BairroID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.BairroID);
            
            CreateTable(
                "dbo.Borda",
                c => new
                    {
                        BordaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descricao = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.BordaID);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        CidadeID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.CidadeID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        ClienteID = c.Int(nullable: false),
                        Fixo = c.String(maxLength: 13, unicode: false, storeType: "nvarchar"),
                        Celular = c.String(nullable: false, maxLength: 13, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        ClienteID = c.Int(nullable: false),
                        Referencia = c.String(unicode: false),
                        BairroID = c.Int(),
                        CidadeID = c.Int(),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false, storeType: "nvarchar"),
                        LogradouroID = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteID)
                .ForeignKey("dbo.Bairro", t => t.BairroID)
                .ForeignKey("dbo.Cidade", t => t.CidadeID)
                .ForeignKey("dbo.Logradouro", t => t.LogradouroID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.BairroID)
                .Index(t => t.CidadeID)
                .Index(t => t.LogradouroID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Logradouro",
                c => new
                    {
                        LogradouroID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.LogradouroID);
            
            CreateTable(
                "dbo.Complemento",
                c => new
                    {
                        ComplementoID = c.Int(nullable: false, identity: true),
                        SaborID = c.Int(),
                        Descricao = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Produto_ProdutoID = c.Int(),
                    })
                .PrimaryKey(t => t.ComplementoID)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoID)
                .ForeignKey("dbo.Sabor", t => t.SaborID)
                .Index(t => t.Produto_ProdutoID)
                .Index(t => t.SaborID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        TipoProduto = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Codigo = c.String(nullable: false, maxLength: 13, unicode: false, storeType: "nvarchar"),
                        PrecoCompra = c.Decimal(precision: 18, scale: 2),
                        PrecoVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaID = c.Int(nullable: false),
                        Descricao = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        SaborID = c.Int(),
                        BordaID = c.Int(),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.Borda", t => t.BordaID)
                .ForeignKey("dbo.Categoria", t => t.CategoriaID, cascadeDelete: true)
                .ForeignKey("dbo.Sabor", t => t.SaborID)
                .Index(t => t.BordaID)
                .Index(t => t.CategoriaID)
                .Index(t => t.SaborID);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false),
                        Gerenciar = c.Boolean(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        QuantidadeMinima = c.Int(nullable: false),
                        QuantidadeMaxima = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.Produto", t => t.ProdutoID)
                .Index(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Sabor",
                c => new
                    {
                        SaborID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.SaborID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Complemento", "SaborID", "dbo.Sabor");
            DropForeignKey("dbo.Produto", "SaborID", "dbo.Sabor");
            DropForeignKey("dbo.Estoque", "ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.Complemento", "Produto_ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.Produto", "CategoriaID", "dbo.Categoria");
            DropForeignKey("dbo.Produto", "BordaID", "dbo.Borda");
            DropForeignKey("dbo.Endereco", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Endereco", "LogradouroID", "dbo.Logradouro");
            DropForeignKey("dbo.Endereco", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Endereco", "CidadeID", "dbo.Cidade");
            DropForeignKey("dbo.Endereco", "BairroID", "dbo.Bairro");
            DropForeignKey("dbo.Contato", "ClienteID", "dbo.Cliente");
            DropForeignKey("dbo.Contato", "ClienteID", "dbo.Cliente");
            DropIndex("dbo.Complemento", new[] { "SaborID" });
            DropIndex("dbo.Produto", new[] { "SaborID" });
            DropIndex("dbo.Estoque", new[] { "ProdutoID" });
            DropIndex("dbo.Complemento", new[] { "Produto_ProdutoID" });
            DropIndex("dbo.Produto", new[] { "CategoriaID" });
            DropIndex("dbo.Produto", new[] { "BordaID" });
            DropIndex("dbo.Endereco", new[] { "ClienteID" });
            DropIndex("dbo.Endereco", new[] { "LogradouroID" });
            DropIndex("dbo.Endereco", new[] { "CidadeID" });
            DropIndex("dbo.Endereco", new[] { "BairroID" });
            DropIndex("dbo.Contato", new[] { "ClienteID" });
            DropTable("dbo.Sabor");
            DropTable("dbo.Estoque");
            DropTable("dbo.Produto");
            DropTable("dbo.Complemento");
            DropTable("dbo.Logradouro");
            DropTable("dbo.Endereco");
            DropTable("dbo.Contato");
            DropTable("dbo.Cliente");
            DropTable("dbo.Cidade");
            DropTable("dbo.Categoria");
            DropTable("dbo.Borda");
            DropTable("dbo.Bairro");
        }
    }
}
