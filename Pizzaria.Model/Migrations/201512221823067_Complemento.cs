namespace Pizzaria.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Complemento : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Produto", "ComplementoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "ComplementoID", c => c.Int(nullable: false));
        }
    }
}
