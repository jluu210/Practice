namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatedWidgets : DbMigration
    {
        public override void Up()
        {
            //type of widget 1-general 2-construction 3-medical 4-military
            Sql("INSERT INTO " +
                "Widgets(Name, DateAddedToStock, NumberInStock, WidgetType_Id) " +
                "VALUES('GeneralWiget-001', 10/1/1955, 50, 1)"
                );
            Sql("INSERT INTO " +
                "Widgets(Name, DateAddedToStock, NumberInStock, WidgetType_Id) " +
                "VALUES('GeneralWiget-032', 11/3/1932, 101, 1)"
                );
            Sql("INSERT INTO " +
                "Widgets(Name, DateAddedToStock, NumberInStock, WidgetType_Id) " +
                "VALUES('ContructionWidget-003', 01/2/1980, 50, 2)"
                );
            Sql("INSERT INTO " +
                "Widgets(Name, DateAddedToStock, NumberInStock, WidgetType_Id) " +
                "VALUES('MedicalWidget-015', 12/1/1960, 150, 3)"
                );
            Sql("INSERT INTO " +
                "Widgets(Name, DateAddedToStock, NumberInStock, WidgetType_Id) " +
                "VALUES('MilitaryWidget-900', 3/16/1956, 102, 4)"
                );

        }

        public override void Down()
        {
        }
    }
}
