using Enterprises.CMS.EntityFramework;

namespace Enterprises.CMS.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly CMSDbContext _context;

        public InitialDataBuilder(CMSDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
        }
    }
}
