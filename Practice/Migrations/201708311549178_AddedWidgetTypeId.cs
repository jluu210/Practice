namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWidgetTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Widgets", "WidgetType_Id", "dbo.WidgetTypes");
            DropIndex("dbo.Widgets", new[] { "WidgetType_Id" });
            RenameColumn(table: "dbo.Widgets", name: "WidgetType_Id", newName: "WidgetTypeId");
            AlterColumn("dbo.Widgets", "WidgetTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Widgets", "WidgetTypeId");
            AddForeignKey("dbo.Widgets", "WidgetTypeId", "dbo.WidgetTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Widgets", "WidgetTypeId", "dbo.WidgetTypes");
            DropIndex("dbo.Widgets", new[] { "WidgetTypeId" });
            AlterColumn("dbo.Widgets", "WidgetTypeId", c => c.Byte());
            RenameColumn(table: "dbo.Widgets", name: "WidgetTypeId", newName: "WidgetType_Id");
            CreateIndex("dbo.Widgets", "WidgetType_Id");
            AddForeignKey("dbo.Widgets", "WidgetType_Id", "dbo.WidgetTypes", "Id");
        }
    }
}
