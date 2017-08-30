namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMembershipType1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "TypeOfMembership", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "TypeOfMembership", c => c.Byte(nullable: false));
        }
    }
}
