namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Newint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "newCompanyID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "newCompanyID");
        }
    }
}
