namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDbset : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO " +
                "Widgets(Name, DateAddedToStock, NumberInStock, WidgetType_Id) " +
                "VALUES('MilitaryWidget-4500', '3/16/1956', 102, 4)"
                );
        }
        
        public override void Down()
        {
        }
    }
}
