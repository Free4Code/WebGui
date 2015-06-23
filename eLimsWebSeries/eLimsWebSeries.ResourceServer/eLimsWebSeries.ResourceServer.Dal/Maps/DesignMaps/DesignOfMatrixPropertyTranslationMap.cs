// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyTranslationMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfMatrixPropertyTranslationMap : EntityTypeConfiguration<DesignOfMatrixPropertyTranslation>
    {
        public DesignOfMatrixPropertyTranslationMap()
        {
            // table name
            this.ToTable("designOfMatrixPropertyTranslations");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixPropertyTranslationId");

            // Relationship
            this.HasRequired(d => d.TranslatedMatrixProperty).WithMany().HasForeignKey(d => d.TranslatedMatrixPropertyId);
            this.HasRequired(d => d.Language).WithMany().HasForeignKey(d => d.LanguageId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.TranslatedName).HasColumnName("translatedName").IsRequired();

            // Optional Properties
            this.Property(d => d.TranslatedComment).HasColumnName("translatedComment").IsOptional();

            // Ignored Properties
        }
    }
}