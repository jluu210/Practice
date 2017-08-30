namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatedWidgetTypes : DbMigration
    {
        public override void Up()
        {
            //type of widget 1-general 2-construction 3-medical 4-military
            Sql("INSERT INTO " +
                "WidgetTypes(Id, TypeOfWidget, Price, Description) " +
                "VALUES(1, 'general', 10, 'General widgets are used for everything but are weak.')"
                );
            Sql("INSERT INTO " +
                "WidgetTypes(Id, TypeOfWidget, Price, Description) " +
                "VALUES(2, 'construction', 40, 'Construction widgets are used for building.')"
                );
            Sql("INSERT INTO " +
                "WidgetTypes(Id, TypeOfWidget, Price, Description) " +
                "VALUES(3, 'medical', 50, 'Medical widgets are used when people are sick.')"
                );
            Sql("INSERT INTO " +
                "WidgetTypes(Id, TypeOfWidget, Price, Description) " +
                "VALUES(4, 'military', 150, 'Military widgets are used for battle!')"
                );

        }

        public override void Down()
        {
        }
    }
}
