namespace EFTask.netfarmework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberInBorrow : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Borrows", new[] { "Member_MemberId" });
            CreateIndex("dbo.Borrows", "member_MemberId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Borrows", new[] { "member_MemberId" });
            CreateIndex("dbo.Borrows", "Member_MemberId");
        }
    }
}
