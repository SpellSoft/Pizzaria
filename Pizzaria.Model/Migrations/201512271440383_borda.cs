namespace Pizzaria.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class borda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Borda",
                c => new
                    {
                        BordaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Preco = c.Double(nullable: false),
                        Descricao = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.BordaID);
            
            AddColumn("dbo.Produto", "BordaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Produto", "BordaID");
            AddForeignKey("dbo.Produto", "BordaID", "dbo.Borda", "BordaID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "BordaID", "dbo.Borda");
            DropIndex("dbo.Produto", new[] { "BordaID" });
            DropColumn("dbo.Produto", "BordaID");
            DropTable("dbo.Borda");
        }
    }
}
