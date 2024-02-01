namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCompanyID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Members", "CompanyID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "CompanyID", c => c.String());
        }
    }
}
