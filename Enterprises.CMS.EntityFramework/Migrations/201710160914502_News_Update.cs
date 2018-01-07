namespace Enterprises.CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class News_Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "ThumbMediaId", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.News", "ContentSourceUrl", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.News", "ReadNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "ReadNum", c => c.Long(nullable: false));
            AlterColumn("dbo.News", "ContentSourceUrl", c => c.String(unicode: false));
            AlterColumn("dbo.News", "ThumbMediaId", c => c.String(unicode: false));
        }
    }
}
