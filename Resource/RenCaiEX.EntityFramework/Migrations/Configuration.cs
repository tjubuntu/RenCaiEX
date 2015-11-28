using System.Data.Entity.Migrations;
using RenCaiEX.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace RenCaiEX.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RenCaiEX.EntityFramework.RenCaiEXDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RenCaiEX";
        }

        protected override void Seed(RenCaiEX.EntityFramework.RenCaiEXDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
