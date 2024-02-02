namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mapdto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Members", new[] { "CompanyID" });
            CreateTable(
                "dbo.AddCompanyDtoes",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CompanyPhone = c.String(),
                        CompanyAddress = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            AddColumn("dbo.Companies", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Members", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Members", "Company_CompanyId", c => c.Int());
            AddColumn("dbo.SoppingLists", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.SoppingLists", "members_MemberId", c => c.Int());
            CreateIndex("dbo.Members", "Company_CompanyId");
            CreateIndex("dbo.SoppingLists", "members_MemberId");
            AddForeignKey("dbo.SoppingLists", "members_MemberId", "dbo.Members", "MemberId");
            AddForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies", "CompanyId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.SoppingLists", "members_MemberId", "dbo.Members");
            DropIndex("dbo.SoppingLists", new[] { "members_MemberId" });
            DropIndex("dbo.Members", new[] { "Company_CompanyId" });
            DropColumn("dbo.SoppingLists", "members_MemberId");
            DropColumn("dbo.SoppingLists", "Discriminator");
            DropColumn("dbo.Members", "Company_CompanyId");
            DropColumn("dbo.Members", "Discriminator");
            DropColumn("dbo.Companies", "Discriminator");
            DropTable("dbo.AddCompanyDtoes");
            CreateIndex("dbo.Members", "CompanyID");
            AddForeignKey("dbo.Members", "CompanyID", "dbo.Companies", "CompanyId", cascadeDelete: true);
        }
    }
}
