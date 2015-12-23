namespace Pizzaria.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prods3dsd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Complemento",
                c => new
                    {
                        ComplementoID = c.Int(nullable: false, identity: true),
                        SaborID = c.Int(nullable: false),
                        Descricao = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Preco = c.Double(nullable: false),
                        Produto_ProdutoID = c.Int(),
                    })
                .PrimaryKey(t => t.ComplementoID)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoID)
                .ForeignKey("dbo.Sabor", t => t.SaborID, cascadeDelete: true)
                .Index(t => t.Produto_ProdutoID)
                .Index(t => t.SaborID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Codigo = c.String(nullable: false, maxLength: 13, unicode: false, storeType: "nvarchar"),
                        PrecoCompra = c.Double(),
                        PrecoVenda = c.Double(nullable: false),
                        CategoriaID = c.Int(nullable: false),
                        Descricao = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        SaborID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.Categoria", t => t.CategoriaID, cascadeDelete: true)
                .ForeignKey("dbo.Sabor", t => t.SaborID, cascadeDelete: true)
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
            DropIndex("dbo.Complemento", new[] { "SaborID" });
            DropIndex("dbo.Produto", new[] { "SaborID" });
            DropIndex("dbo.Estoque", new[] { "ProdutoID" });
            DropIndex("dbo.Complemento", new[] { "Produto_ProdutoID" });
            DropIndex("dbo.Produto", new[] { "CategoriaID" });
            DropTable("dbo.Sabor");
            DropTable("dbo.Estoque");
            DropTable("dbo.Produto");
            DropTable("dbo.Complemento");
            DropTable("dbo.Categoria");
        }
    }
}
