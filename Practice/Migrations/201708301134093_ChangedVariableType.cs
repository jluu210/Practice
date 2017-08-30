namespace Practice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedVariableType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Byte(nullable: false));
        }
    }
}
