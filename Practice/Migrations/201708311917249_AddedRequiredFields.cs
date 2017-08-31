namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Widgets", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Widgets", "Name", c => c.String());
        }
    }
}
