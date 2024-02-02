namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class error : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AddCompanyDtoes");
        }
        
        public override void Down()
        {
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
            
        }
    }
}
