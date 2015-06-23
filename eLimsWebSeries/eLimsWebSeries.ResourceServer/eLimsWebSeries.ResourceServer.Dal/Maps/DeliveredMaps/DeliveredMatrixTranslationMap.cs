// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixTranslationMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;

    public sealed class DeliveredMatrixTranslationMap : EntityTypeConfiguration<DeliveredMatrixTranslation>
    {
        public DeliveredMatrixTranslationMap()
        {
            // table name
            this.ToTable("deliveredMatrixTranslations");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("deliveredMatrixTranslationId");

            // Relationship
            this.HasRequired(d => d.TranslatedMatrix).WithMany().HasForeignKey(d => d.TranslatedMatrixId);
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
