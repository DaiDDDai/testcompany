namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewOBJ1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "Company_CompanyId", c => c.Int());
            CreateIndex("dbo.Members", "Company_CompanyId");
            AddForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies", "CompanyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.Members", new[] { "Company_CompanyId" });
            DropColumn("dbo.Members", "Company_CompanyId");
        }
    }
}
