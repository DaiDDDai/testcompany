namespace test4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class shoppingdto : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SoppingLists", "MemberID");
            AddForeignKey("dbo.SoppingLists", "MemberID", "dbo.Members", "MemberId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SoppingLists", "MemberID", "dbo.Members");
            DropIndex("dbo.SoppingLists", new[] { "MemberID" });
        }
    }
}
