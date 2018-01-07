namespace Enterprises.CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class News : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Digest = c.String(nullable: false, maxLength: 500, storeType: "nvarchar"),
                        Author = c.String(maxLength: 100, storeType: "nvarchar"),
                        Content = c.String(nullable: false, unicode: false),
                        ThumbMediaId = c.String(unicode: false),
                        ShowCoverPic = c.Boolean(nullable: false),
                        NeedOpenComment = c.Boolean(nullable: false),
                        OnlyFansCanComment = c.Boolean(nullable: false),
                        ContentSourceUrl = c.String(unicode: false),
                        ReadNum = c.Long(nullable: false),
                        Enabled = c.Boolean(nullable: false),
                        SortOrder = c.Int(nullable: false),
                        NewsTypeId = c.Long(nullable: false),
                        CreationTime = c.DateTime(nullable: false, precision: 0),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewsType", t => t.NewsTypeId, cascadeDelete: true)
                .Index(t => t.NewsTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "NewsTypeId", "dbo.NewsType");
            DropIndex("dbo.News", new[] { "NewsTypeId" });
            DropTable("dbo.News");
        }
    }
}
