// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfLanguageTranslationMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfLanguageTranslationMap : EntityTypeConfiguration<DesignOfLanguageTranslation>
    {
        public DesignOfLanguageTranslationMap()
        {
            // table name
            this.ToTable("designOfLanguageTranslations");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfLanguageTranslationId");

            // Relationship
            this.HasRequired(d => d.TranslatedLanguage).WithMany().HasForeignKey(d => d.TranslatedLanguageId);
            this.HasRequired(d => d.Language).WithMany().HasForeignKey(d => d.LanguageId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.TranslatedName).HasColumnName("translatedName").IsRequired();

            // Optional Properties

            // Ignored Properties
        }
    }
}