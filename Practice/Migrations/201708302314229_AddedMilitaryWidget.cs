namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMilitaryWidget : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO " +
                "Widgets(Name, DateAddedToStock, NumberInStock, WidgetType_Id) " +
                "VALUES('MilitaryWidget-101', '3/06/1901', 102, 4)"
                );
        }
        
        public override void Down()
        {
        }
    }
}
