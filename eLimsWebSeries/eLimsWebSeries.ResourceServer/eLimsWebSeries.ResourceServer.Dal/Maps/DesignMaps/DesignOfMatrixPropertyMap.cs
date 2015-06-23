// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfMatrixPropertyMap : EntityTypeConfiguration<DesignOfMatrixProperty>
    {
        public DesignOfMatrixPropertyMap()
        {
            // table name
            this.ToTable("designOfMatrixProperties");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixPropertyId");

            // Relationship
            this.HasMany(d => d.Choices).WithOptional(c => c.MatrixProperty).HasForeignKey(c => c.MatrixPropertyId);
            this.HasMany(d => d.Trackings).WithOptional(t => t.MatrixProperty).HasForeignKey(t => t.MatrixPropertyId);
            this.HasMany(d => d.Translations).WithOptional(t => t.TranslatedMatrixProperty).HasForeignKey(t => t.TranslatedMatrixPropertyId);

            // Other configurations
            this.Property(d => d.Code)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed)
                .HasColumnName("code");
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.TypeEnum).HasColumnName("type").IsRequired();
            this.Property(d => d.StateEnum).HasColumnName("state").IsRequired();
            this.Property(d => d.InternalName).HasColumnName("internalName").IsRequired();

            // Optional Properties
            this.Property(d => d.InternalComment).HasColumnName("internalComment").IsOptional();

            // Ignored Properties
            this.Ignore(d => d.Type);
            this.Ignore(d => d.State);
        }
    }
}
