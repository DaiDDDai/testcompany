namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewOBJ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "CompanyID", c => c.String());
            AddColumn("dbo.SoppingLists", "MemberID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SoppingLists", "MemberID");
            DropColumn("dbo.Members", "CompanyID");
        }
    }
}
