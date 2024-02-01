namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNewCompanyID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "newCompanyID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "newCompanyID", c => c.Int(nullable: false));
        }
    }
}
