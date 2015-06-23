// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixPropertyTranslationMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;

    public sealed class DeliveredMatrixPropertyTranslationMap : EntityTypeConfiguration<DeliveredMatrixPropertyTranslation>
    {
        public DeliveredMatrixPropertyTranslationMap()
        {
            // table name
            this.ToTable("deliveredMatrixPropertyTranslations");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("deliveredMatrixPropertyTranslationId");

            // Relationship
            this.HasRequired(d => d.TranslatedMatrixProperty).WithMany().HasForeignKey(d => d.TranslatedMatrixPropertyId);
            this.HasRequired(d => d.Language).WithMany().HasForeignKey(d => d.LanguageId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.TranslatedName).HasColumnName("translatedName").IsRequired();
            this.Property(d => d.Version).HasColumnName("version").IsRequired();
            this.Property(d => d.StartingValidityDate).HasColumnName("startingValidityDate").IsRequired();
            this.Property(d => d.EndingValidityDate).HasColumnName("endingValidityDate").IsRequired();

            // Optional Properties
            this.Property(d => d.TranslatedComment).HasColumnName("translatedComment").IsOptional();

            // Ignored Properties
        }
    }
}