namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSubScribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSubScribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "isSubScribed");
        }
    }
}
