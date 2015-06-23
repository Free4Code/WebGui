// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// <summary>
//   The matrix design map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    /// <summary>
    /// The matrix design map.
    /// </summary>
    public sealed class DesignOfMatrixMap : EntityTypeConfiguration<DesignOfMatrix>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignOfMatrixMap"/> class.
        /// </summary>
        public DesignOfMatrixMap()
        {
            // table name
            this.ToTable("designOfMatrices");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixId");

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
            this.Property(m => m.StateEnum).HasColumnName("state").IsRequired();
            this.Property(m => m.InternalName).HasColumnName("internalName").IsRequired();

            // Optional Properties
            this.Property(m => m.InternalComment).HasColumnName("internalComment").IsOptional();
            this.Property(m => m.Hierarchy).HasColumnName("hierarchy").IsOptional();

            // Ignored Properties
            this.Ignore(m => m.Type);
            this.Ignore(m => m.State);
        }

        #endregion
    }
}