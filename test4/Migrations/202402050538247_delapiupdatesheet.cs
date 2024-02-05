namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class delapiupdatesheet : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.UpdateCompanies");
            DropTable("dbo.UpdateMembers");
            DropTable("dbo.UpdateShoppingLists");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UpdateShoppingLists",
                c => new
                    {
                        SoppingListId = c.Int(nullable: false, identity: true),
                        Items = c.String(),
                        Amount = c.Int(nullable: false),
                        Money = c.Int(nullable: false),
                        MemberID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SoppingListId);
            
            CreateTable(
                "dbo.UpdateMembers",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.UpdateCompanies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CompanyPhone = c.String(),
                        CompanyAddress = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
        }
    }
}
