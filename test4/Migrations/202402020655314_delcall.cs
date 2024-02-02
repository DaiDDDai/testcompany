namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delcall : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.SoppingLists", "members_MemberId", "dbo.Members");
            DropForeignKey("dbo.SoppingLists", "MemberID", "dbo.Members");
            DropIndex("dbo.Members", new[] { "Company_CompanyId" });
            DropIndex("dbo.SoppingLists", new[] { "MemberID" });
            DropIndex("dbo.SoppingLists", new[] { "members_MemberId" });
            DropColumn("dbo.Companies", "Discriminator");
            DropColumn("dbo.Members", "Discriminator");
            DropColumn("dbo.Members", "Company_CompanyId");
            DropColumn("dbo.SoppingLists", "Discriminator");
            DropColumn("dbo.SoppingLists", "members_MemberId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SoppingLists", "members_MemberId", c => c.Int());
            AddColumn("dbo.SoppingLists", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Members", "Company_CompanyId", c => c.Int());
            AddColumn("dbo.Members", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Companies", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.SoppingLists", "members_MemberId");
            CreateIndex("dbo.SoppingLists", "MemberID");
            CreateIndex("dbo.Members", "Company_CompanyId");
            AddForeignKey("dbo.SoppingLists", "MemberID", "dbo.Members", "MemberId", cascadeDelete: true);
            AddForeignKey("dbo.SoppingLists", "members_MemberId", "dbo.Members", "MemberId");
            AddForeignKey("dbo.Members", "Company_CompanyId", "dbo.Companies", "CompanyId");
        }
    }
}
