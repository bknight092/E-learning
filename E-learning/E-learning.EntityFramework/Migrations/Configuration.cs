using System.Data.Entity.Migrations;

namespace E-learning.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<E-learning.EntityFramework.E-learningDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "E-learning";
        }

        protected override void Seed(E-learning.EntityFramework.E-learningDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
