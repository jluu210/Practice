namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, TypeOfMemberShip) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, TypeOfMemberShip) VALUES (2, 5, 1, 1)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, TypeOfMemberShip) VALUES (3, 10, 3, 2)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, TypeOfMemberShip) VALUES (4, 20, 6, 3)");


        }

        public override void Down()
        {
        }
    }
}
