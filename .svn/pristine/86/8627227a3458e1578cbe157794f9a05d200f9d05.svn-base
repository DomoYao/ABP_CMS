namespace Enterprises.CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class File : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "LastModificationTime", c => c.DateTime(precision: 0));
            AddColumn("dbo.Files", "LastModifierUserId", c => c.Long());
            AddColumn("dbo.News", "LastModificationTime", c => c.DateTime(precision: 0));
            AddColumn("dbo.News", "LastModifierUserId", c => c.Long());
            AddColumn("dbo.NewsType", "LastModificationTime", c => c.DateTime(precision: 0));
            AddColumn("dbo.NewsType", "LastModifierUserId", c => c.Long());
            DropColumn("dbo.Files", "CreateBy");
            DropColumn("dbo.Files", "CreateDate");
            DropColumn("dbo.Files", "UpdateBy");
            DropColumn("dbo.Files", "UpdateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Files", "UpdateDate", c => c.DateTime(precision: 0));
            AddColumn("dbo.Files", "UpdateBy", c => c.String(unicode: false));
            AddColumn("dbo.Files", "CreateDate", c => c.DateTime(precision: 0));
            AddColumn("dbo.Files", "CreateBy", c => c.String(unicode: false));
            DropColumn("dbo.NewsType", "LastModifierUserId");
            DropColumn("dbo.NewsType", "LastModificationTime");
            DropColumn("dbo.News", "LastModifierUserId");
            DropColumn("dbo.News", "LastModificationTime");
            DropColumn("dbo.Files", "LastModifierUserId");
            DropColumn("dbo.Files", "LastModificationTime");
        }
    }
}
