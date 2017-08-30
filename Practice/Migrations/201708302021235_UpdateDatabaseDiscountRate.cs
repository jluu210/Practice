namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseDiscountRate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET DiscountRate = 0 WHERE MembershipTypes.Id = 1;");
            Sql("UPDATE MembershipTypes SET DiscountRate = 5 WHERE MembershipTypes.Id = 2;");
            Sql("UPDATE MembershipTypes SET DiscountRate = 10 WHERE MembershipTypes.Id = 3;");
            Sql("UPDATE MembershipTypes SET DiscountRate = 20 WHERE MembershipTypes.Id = 4;");

        }

        public override void Down()
        {
        }
    }
}
