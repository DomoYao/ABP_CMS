namespace Enterprises.CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editdb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbpUsers", "Mobile", c => c.String(nullable: false, maxLength: 13));
            AddColumn("dbo.AbpUsers", "IsMobileConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.AbpUsers", "MobileConfirmationCode", c => c.String(maxLength: 8));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbpUsers", "MobileConfirmationCode");
            DropColumn("dbo.AbpUsers", "IsMobileConfirmed");
            DropColumn("dbo.AbpUsers", "Mobile");
        }
    }
}
