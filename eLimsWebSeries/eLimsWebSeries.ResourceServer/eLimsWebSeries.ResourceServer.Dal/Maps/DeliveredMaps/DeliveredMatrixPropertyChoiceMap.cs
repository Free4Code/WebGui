// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixPropertyChoiceMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;

    public sealed class DeliveredMatrixPropertyChoiceMap : EntityTypeConfiguration<DeliveredMatrixPropertyChoice>
    {
        #region Constructors and Destructors

        public DeliveredMatrixPropertyChoiceMap()
        {
            // table name
            this.ToTable("deliveredMatrixPropertyChoices");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("deliveredMatrixPropertyChoiceId");

            // Relationship
            this.HasOptional(d => d.MatrixProperty).WithMany().HasForeignKey(d => d.MatrixPropertyId);
            this.HasMany(d => d.Translations)
                .WithOptional(t => t.TranslatedMatrixPropertyChoice)
                .HasForeignKey(t => t.TranslatedMatrixPropertyChoiceId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(m => m.InternalName).HasColumnName("internalName").IsRequired();
            this.Property(d => d.Version).HasColumnName("version").IsRequired();
            this.Property(d => d.StartingValidityDate).HasColumnName("startingValidityDate").IsRequired();
            this.Property(d => d.EndingValidityDate).HasColumnName("endingValidityDate").IsRequired();

            // Optional Properties

            // Ignored Properties
        }

        #endregion
    }
}