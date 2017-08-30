namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMembershipType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "TypeOfMembership", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "TypeOfMembership", c => c.String());
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
        }
    }
}
