// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyChoiceMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfMatrixPropertyChoiceMap : EntityTypeConfiguration<DesignOfMatrixPropertyChoice>
    {
        #region Constructors and Destructors

        public DesignOfMatrixPropertyChoiceMap()
        {
            // table name
            this.ToTable("designOfMatrixPropertyChoices");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixPropertyChoiceId");

            // Relationship
            this.HasOptional(d => d.MatrixProperty).WithMany().HasForeignKey(d => d.MatrixPropertyId);
            this.HasMany(d => d.Translations)
                .WithOptional(t => t.TranslatedMatrixPropertyChoice)
                .HasForeignKey(t => t.TranslatedMatrixPropertyChoiceId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(m => m.InternalName).HasColumnName("internalName").IsRequired();

            // Optional Properties

            // Ignored Properties
        }

        #endregion
    }
}