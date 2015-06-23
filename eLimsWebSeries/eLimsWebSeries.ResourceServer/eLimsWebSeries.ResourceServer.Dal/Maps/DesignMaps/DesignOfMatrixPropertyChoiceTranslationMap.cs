// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyChoiceTranslationMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfMatrixPropertyChoiceTranslationMap : EntityTypeConfiguration<DesignOfMatrixPropertyChoiceTranslation>
    {
        public DesignOfMatrixPropertyChoiceTranslationMap()
        {
            // table name
            this.ToTable("designOfMatrixPropertyChoiceTranslations");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixPropertyChoiceTranslationId");

            // Relationship
            this.HasRequired(d => d.TranslatedMatrixPropertyChoice).WithMany().HasForeignKey(d => d.TranslatedMatrixPropertyChoiceId);
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