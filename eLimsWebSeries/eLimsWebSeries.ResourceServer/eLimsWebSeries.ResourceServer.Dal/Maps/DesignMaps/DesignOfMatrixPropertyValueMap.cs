// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyValueMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfMatrixPropertyValueMap : EntityTypeConfiguration<DesignOfMatrixPropertyValue>
    {
        public DesignOfMatrixPropertyValueMap()
        {
            // table name
            this.ToTable("designOfMatrixPropertyValues");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixPropertyValueId");

            // Relationship
            this.HasRequired(d => d.Matrix).WithMany().HasForeignKey(d => d.MatrixId);
            this.HasRequired(d => d.MatrixProperty).WithMany().HasForeignKey(d => d.MatrixPropertyId);
            this.HasOptional(d => d.MatrixPropertyChoice).WithMany().HasForeignKey(d => d.MatrixPropertyChoiceId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.NumericalTypeEnum).HasColumnName("numericalType").IsRequired();
            
            // Optional Properties
            this.Property(d => d.BoolValue).HasColumnName("boolValue").IsOptional();
            this.Property(d => d.DoubleValue1).HasColumnName("doubleValue1").IsOptional();
            this.Property(d => d.DoubleValue2).HasColumnName("doubleValue2").IsOptional();

            // Ignored Properties
            this.Ignore(d => d.Value);
            this.Ignore(d => d.NumericalType);
        }
    }
}
