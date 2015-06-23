// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyTrackingMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfMatrixPropertyTrackingMap : EntityTypeConfiguration<DesignOfMatrixPropertyTracking>
    {
        public DesignOfMatrixPropertyTrackingMap()
        {
            // table name
            this.ToTable("designOfMatrixPropertyTrackings");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixPropertyTrackingId");

            // Relationship
            this.HasRequired(d => d.MatrixProperty).WithMany().HasForeignKey(d => d.MatrixPropertyId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.StartingStateEnum).HasColumnName("startingState").IsRequired();
            this.Property(d => d.EndingStateEnum).HasColumnName("endingState").IsRequired();
            this.Property(d => d.ActionName).HasColumnName("actionName").IsRequired();
            this.Property(d => d.ActionDate).HasColumnName("actionDate").IsRequired();
            this.Property(d => d.ActionUser).HasColumnName("actionUser").IsRequired();

            // Optional Properties
            this.Property(d => d.Context).HasColumnName("context").IsOptional();

            // Ignored Properties
            this.Ignore(d => d.StartingState);
            this.Ignore(d => d.EndingState);
        }
    }
}