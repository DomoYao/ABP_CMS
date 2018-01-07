using System.Data.Entity.Migrations;
using Enterprises.CMS.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Enterprises.CMS.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CMS.EntityFramework.CMSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CMS";
        }

        protected override void Seed(CMS.EntityFramework.CMSDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
