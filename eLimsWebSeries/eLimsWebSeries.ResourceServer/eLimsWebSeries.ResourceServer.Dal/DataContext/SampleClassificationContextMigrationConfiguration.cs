namespace eLimsWebSeries.ResourceServer.Dal.DataContext
{
    using System.Data.Entity.Migrations;

    using eLimsWebSeries.ResourceServer.Dal.SeedData;

    internal class SampleClassificationContextMigrationConfiguration : DbMigrationsConfiguration<SampleClassificationContext>
    {
        public SampleClassificationContextMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

#if DEBUG
        protected override void Seed(SampleClassificationContext context)
        {
            new SampleClassificationDataSeeder(context).Seed();
        }
#endif

    }
}