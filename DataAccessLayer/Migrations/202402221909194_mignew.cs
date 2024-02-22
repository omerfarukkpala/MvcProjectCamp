namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mignew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        AboutDetails1 = c.String(maxLength: 1000),
                        AboutDetails2 = c.String(maxLength: 1000),
                        AboutImage1 = c.String(maxLength: 100),
                        AboutImage2 = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        AdminUserName = c.String(maxLength: 50),
                        AdminPassword = c.String(maxLength: 50),
                        AdminRole = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 50),
                        CategoryDescription = c.String(maxLength: 200),
                        CategoryStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Headings",
                c => new
                    {
                        HeadingID = c.Int(nullable: false, identity: true),
                        HeadingName = c.String(maxLength: 50),
                        HeadingDate = c.DateTime(nullable: false),
                        HeadingStatus = c.Boolean(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        WriterID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HeadingID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Writers", t => t.WriterID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.WriterID);
            
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        ContentID = c.Int(nullable: false, identity: true),
                        ContentValue = c.String(maxLength: 1000),
                        ContentDate = c.DateTime(nullable: false),
                        ContentStatus = c.Boolean(nullable: false),
                        HeadingID = c.Int(nullable: false),
                        WriterID = c.Int(),
                    })
                .PrimaryKey(t => t.ContentID)
                .ForeignKey("dbo.Headings", t => t.HeadingID, cascadeDelete: true)
                .ForeignKey("dbo.Writers", t => t.WriterID)
                .Index(t => t.HeadingID)
                .Index(t => t.WriterID);
            
            CreateTable(
                "dbo.Writers",
                c => new
                    {
                        WriterID = c.Int(nullable: false, identity: true),
                        WriterName = c.String(maxLength: 50),
                        WriterSurname = c.String(maxLength: 50),
                        WriterImage = c.String(maxLength: 500),
                        WriterAbout = c.String(maxLength: 100),
                        WriterMail = c.String(maxLength: 200),
                        WriterPassword = c.String(maxLength: 200),
                        WriterTitle = c.String(maxLength: 50),
                        WriterStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.WriterID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        UserMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 50),
                        ContactDate = c.DateTime(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.ImageFiles",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageName = c.String(maxLength: 100),
                        ImagePath = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ImageID);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        SenderMail = c.String(maxLength: 50),
                        ReceiverMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 100),
                        MessageContent = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        MessageStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 25),
                        Surname = c.String(maxLength: 25),
                        TitleInfo = c.String(maxLength: 250),
                        ImageUrl = c.String(maxLength: 100),
                        Ability1 = c.String(maxLength: 100),
                        AbilityRate1 = c.Int(nullable: false),
                        Ability2 = c.String(maxLength: 100),
                        AbilityRate2 = c.Int(nullable: false),
                        Ability3 = c.String(maxLength: 100),
                        AbilityRate3 = c.Int(nullable: false),
                        Ability4 = c.String(maxLength: 100),
                        AbilityRate4 = c.Int(nullable: false),
                        Ability5 = c.String(maxLength: 100),
                        AbilityRate5 = c.Int(nullable: false),
                        Ability6 = c.String(maxLength: 100),
                        AbilityRate6 = c.Int(nullable: false),
                        Ability7 = c.String(maxLength: 100),
                        AbilityRate7 = c.Int(nullable: false),
                        Ability8 = c.String(maxLength: 100),
                        AbilityRate8 = c.Int(nullable: false),
                        GitHubUrl = c.String(maxLength: 100),
                        LinkedinUrl = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropForeignKey("dbo.Contents", "WriterID", "dbo.Writers");
            DropForeignKey("dbo.Contents", "HeadingID", "dbo.Headings");
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Contents", new[] { "WriterID" });
            DropIndex("dbo.Contents", new[] { "HeadingID" });
            DropIndex("dbo.Headings", new[] { "WriterID" });
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            DropTable("dbo.Skills");
            DropTable("dbo.Messages");
            DropTable("dbo.ImageFiles");
            DropTable("dbo.Contacts");
            DropTable("dbo.Writers");
            DropTable("dbo.Contents");
            DropTable("dbo.Headings");
            DropTable("dbo.Categories");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
        }
    }
}
