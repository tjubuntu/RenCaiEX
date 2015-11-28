using RenCaiEX.EntityFramework;

namespace RenCaiEX.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly RenCaiEXDbContext _context;

        public InitialDataBuilder(RenCaiEXDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
