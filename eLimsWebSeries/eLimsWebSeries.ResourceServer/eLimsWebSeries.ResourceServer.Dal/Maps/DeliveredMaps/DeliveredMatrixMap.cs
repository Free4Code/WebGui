// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// <summary>
//   The matrix design map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;

    public sealed class DeliveredMatrixMap : EntityTypeConfiguration<DeliveredMatrix>
    {
        #region Constructors and Destructors

        public DeliveredMatrixMap()
        {
            // table name
            this.ToTable("deliveredMatrices");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("deliveredMatrixId");

            // Relationship
            this.HasOptional(d => d.Parent).WithMany().HasForeignKey(d => d.ParentId);
            this.HasMany(d => d.MatrixPropertyValues).WithOptional(m => m.Matrix).HasForeignKey(m => m.MatrixId);
            this.HasMany(d => d.Trackings).WithOptional(t => t.Matrix).HasForeignKey(t => t.Matrix);
            this.HasMany(d => d.Translations).WithOptional(t => t.TranslatedMatrix).HasForeignKey(t => t.TranslatedMatrixId);

            // Other configurations
            this.Property(d => d.Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnName("code");
            this.Property(d => d.ParentId).HasColumnName("designOfMatrixParentId");
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.TypeEnum).HasColumnName("type").IsRequired();
            this.Property(m => m.InternalName).HasColumnName("internalName").IsRequired();
            this.Property(d => d.Version).HasColumnName("version").IsRequired();
            this.Property(d => d.StartingValidityDate).HasColumnName("startingValidityDate").IsRequired();
            this.Property(d => d.EndingValidityDate).HasColumnName("endingValidityDate").IsRequired();

            // Optional Properties
            this.Property(m => m.InternalComment).HasColumnName("internalComment").IsOptional();
            this.Property(m => m.Hierarchy).HasColumnName("hierarchy").IsOptional();

            // Ignored Properties
            this.Ignore(m => m.Type);
        }

        #endregion
    }
}