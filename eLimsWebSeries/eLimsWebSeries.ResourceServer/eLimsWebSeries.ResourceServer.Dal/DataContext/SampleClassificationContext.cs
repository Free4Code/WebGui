// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleClassificationContext.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.DataContext
{
    using System.Data.Entity;

    using eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps;
    using eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps;
    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;
    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    using Repository.Pattern.Ef6;

    public sealed class SampleClassificationContext : DataContext
    {
        static SampleClassificationContext()
        {
            // Database.SetInitializer<SampleClassificationContext>(null);
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion
                    <SampleClassificationContext, SampleClassificationContextMigrationConfiguration>());
        }

        public SampleClassificationContext()
            : base("Name=SampleClassificationContext")
        {
        }

        public DbSet<DeliveredLanguage> DeliveredLanguages { get; set; }
        public DbSet<DeliveredLanguageTranslation> DeliveredLanguageTranslations { get; set; }
        public DbSet<DeliveredMatrix> DeliveredMatrices { get; set; }
        public DbSet<DeliveredMatrixProperty> DeliveredMatrixProperties { get; set; }
        public DbSet<DeliveredMatrixPropertyChoice> DeliveredMatrixPropertyChoices { get; set; }
        public DbSet<DeliveredMatrixPropertyChoiceTranslation> DeliveredMatrixPropertyChoiceTranslations { get; set; }
        public DbSet<DeliveredMatrixPropertyTracking> DeliveredMatrixPropertyTrackings { get; set; }
        public DbSet<DeliveredMatrixPropertyTranslation> DeliveredMatrixPropertyTranslations { get; set; }
        public DbSet<DeliveredMatrixPropertyValue> DeliveredMatrixPropertyValues { get; set; }
        public DbSet<DeliveredMatrixTracking> DeliveredMatrixTrackings { get; set; }
        public DbSet<DeliveredMatrixTranslation> DeliveredMatrixTranslations { get; set; }
        public DbSet<DeliveredTracking> DeliveredTrackings { get; set; }
        public DbSet<DeliveredTechnicalTracking> DeliveredTechnicalTrackings { get; set; }

        public DbSet<DesignOfLanguage> DesignOfLanguages { get; set; }
        public DbSet<DesignOfLanguageTranslation> DesignOfLanguageTranslations { get; set; }
        public DbSet<DesignOfMatrix> DesignOfMatrices { get; set; }
        public DbSet<DesignOfMatrixProperty> DesignOfMatrixProperties { get; set; }
        public DbSet<DesignOfMatrixPropertyChoice> DesignOfMatrixPropertyChoices { get; set; }
        public DbSet<DesignOfMatrixPropertyChoiceTranslation> DesignOfMatrixPropertyChoiceTranslations { get; set; }
        public DbSet<DesignOfMatrixPropertyTracking> DesignOfMatrixPropertyTrackings { get; set; }
        public DbSet<DesignOfMatrixPropertyTranslation> DesignOfMatrixPropertyTranslations { get; set; }
        public DbSet<DesignOfMatrixPropertyValue> DesignOfMatrixPropertyValues { get; set; }
        public DbSet<DesignOfMatrixTracking> DesignOfMatrixTrackings { get; set; }
        public DbSet<DesignOfMatrixTranslation> DesignOfMatrixTranslations { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DeliveredLanguageMap());
            modelBuilder.Configurations.Add(new DeliveredLanguageTranslationMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixPropertyMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixPropertyChoiceMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixPropertyChoiceTranslationMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixPropertyTrackingMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixPropertyTranslationMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixPropertyValueMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixTrackingMap());
            modelBuilder.Configurations.Add(new DeliveredMatrixTranslationMap());
            //modelBuilder.Configurations.Add(new DeliveredTrackingeMap());
            //modelBuilder.Configurations.Add(new DeliveredTechnicalTrackingMap());

            modelBuilder.Configurations.Add(new DesignOfLanguageMap());
            modelBuilder.Configurations.Add(new DesignOfLanguageTranslationMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixPropertyMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixPropertyChoiceMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixPropertyChoiceTranslationMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixPropertyTrackingMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixPropertyTranslationMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixPropertyValueMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixTrackingMap());
            modelBuilder.Configurations.Add(new DesignOfMatrixTranslationMap());
        }
    }
}