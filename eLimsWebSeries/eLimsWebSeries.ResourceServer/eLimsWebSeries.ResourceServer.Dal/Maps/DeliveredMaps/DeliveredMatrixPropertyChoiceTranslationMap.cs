// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixPropertyChoiceTranslationMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;

    public sealed class DeliveredMatrixPropertyChoiceTranslationMap : EntityTypeConfiguration<DeliveredMatrixPropertyChoiceTranslation>
    {
        public DeliveredMatrixPropertyChoiceTranslationMap()
        {
            // table name
            this.ToTable("deliveredMatrixPropertyChoiceTranslations");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("deliveredMatrixPropertyChoiceTranslationId");

            // Relationship
            this.HasRequired(d => d.TranslatedMatrixPropertyChoice).WithMany().HasForeignKey(d => d.TranslatedMatrixPropertyChoiceId);
            this.HasRequired(d => d.Language).WithMany().HasForeignKey(d => d.LanguageId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();
            this.Property(d => d.Version).HasColumnName("version").IsRequired();
            this.Property(d => d.StartingValidityDate).HasColumnName("startingValidityDate").IsRequired();
            this.Property(d => d.EndingValidityDate).HasColumnName("endingValidityDate").IsRequired();

            // Required Properties
            this.Property(d => d.TranslatedName).HasColumnName("translatedName").IsRequired();

            // Optional Properties

            // Ignored Properties
        }
    }
}