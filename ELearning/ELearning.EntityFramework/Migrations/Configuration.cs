using System.Data.Entity.Migrations;

namespace ELearning.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ELearning.EntityFramework.ELearningDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ELearning";
        }

        protected override void Seed(ELearning.EntityFramework.ELearningDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
