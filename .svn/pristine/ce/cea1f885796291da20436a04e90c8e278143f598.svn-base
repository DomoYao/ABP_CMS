namespace Enterprises.CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewsType", "TypeName", c => c.String(nullable: false, maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.NewsType", "TypeCode", c => c.String(nullable: false, maxLength: 100, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewsType", "TypeCode", c => c.String(unicode: false));
            AlterColumn("dbo.NewsType", "TypeName", c => c.String(unicode: false));
        }
    }
}
