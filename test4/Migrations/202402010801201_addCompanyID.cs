namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompanyID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.Members", new[] { "Company_CompanyId" });
            RenameColumn(table: "dbo.Members", name: "Company_CompanyId", newName: "CompanyID");
            AlterColumn("dbo.Members", "CompanyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Members", "CompanyID");
            AddForeignKey("dbo.Members", "CompanyID", "dbo.Companies", "CompanyId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Members", new[] { "CompanyID" });
            AlterColumn("dbo.Members", "CompanyID", c => c.Int());
            RenameColumn(table: "dbo.Members", name: "CompanyID", newName: "Company_CompanyId");
            CreateIndex("dbo.Members", "Company_CompanyId");
            AddForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies", "CompanyId");
        }
    }
}
