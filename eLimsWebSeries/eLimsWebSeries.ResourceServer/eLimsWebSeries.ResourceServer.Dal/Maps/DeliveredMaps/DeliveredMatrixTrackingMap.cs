// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixTrackingMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;

    public sealed class DeliveredMatrixTrackingMap : EntityTypeConfiguration<DeliveredMatrixTracking>
    {
        public DeliveredMatrixTrackingMap()
        {
            // table name
            this.ToTable("deliveredMatrixTrackings");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("deliveredMatrixTrackingId");

            // Relationship
            this.HasRequired(d => d.Matrix).WithMany().HasForeignKey(d => d.MatrixId);

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
