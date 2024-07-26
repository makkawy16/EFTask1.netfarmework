namespace EFTask.netfarmework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authours",
                c => new
                    {
                        AuthourId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuthourId);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Authour_AuthourId = c.Int(),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authours", t => t.Authour_AuthourId)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Authour_AuthourId)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ISBN = c.String(),
                        PublisherYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Borrows",
                c => new
                    {
                        BorrowId = c.Int(nullable: false, identity: true),
                        BorrowDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        book_Id = c.Int(),
                        Member_MemberId = c.Int(),
                    })
                .PrimaryKey(t => t.BorrowId)
                .ForeignKey("dbo.Books", t => t.book_Id)
                .ForeignKey("dbo.Members", t => t.Member_MemberId)
                .Index(t => t.book_Id)
                .Index(t => t.Member_MemberId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        MemberShipDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Borrows", "Member_MemberId", "dbo.Members");
            DropForeignKey("dbo.Borrows", "book_Id", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "Authour_AuthourId", "dbo.Authours");
            DropIndex("dbo.Borrows", new[] { "Member_MemberId" });
            DropIndex("dbo.Borrows", new[] { "book_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Book_Id" });
            DropIndex("dbo.BookAuthors", new[] { "Authour_AuthourId" });
            DropTable("dbo.Members");
            DropTable("dbo.Borrows");
            DropTable("dbo.Books");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Authours");
        }
    }
}
