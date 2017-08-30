namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWigetTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WidgetTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        TypeOfWidget = c.String(),
                        Price = c.Byte(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Widgets", "DateAddedToStock", c => c.DateTime(nullable: false));
            AddColumn("dbo.Widgets", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Widgets", "WidgetType_Id", c => c.Byte());
            CreateIndex("dbo.Widgets", "WidgetType_Id");
            AddForeignKey("dbo.Widgets", "WidgetType_Id", "dbo.WidgetTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Widgets", "WidgetType_Id", "dbo.WidgetTypes");
            DropIndex("dbo.Widgets", new[] { "WidgetType_Id" });
            DropColumn("dbo.Widgets", "WidgetType_Id");
            DropColumn("dbo.Widgets", "NumberInStock");
            DropColumn("dbo.Widgets", "DateAddedToStock");
            DropTable("dbo.WidgetTypes");
        }
    }
}
