// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixPropertyMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DeliveredMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities;

    public sealed class DeliveredMatrixPropertyMap : EntityTypeConfiguration<DeliveredMatrixProperty>
    {
        public DeliveredMatrixPropertyMap()
        {
            // table name
            this.ToTable("deliveredMatrixProperties");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("deliveredMatrixPropertyId");

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
            this.Property(d => d.InternalName).HasColumnName("internalName").IsRequired();
            this.Property(d => d.Version).HasColumnName("version").IsRequired();
            this.Property(d => d.StartingValidityDate).HasColumnName("startingValidityDate").IsRequired();
            this.Property(d => d.EndingValidityDate).HasColumnName("endingValidityDate").IsRequired();

            // Optional Properties
            this.Property(d => d.InternalComment).HasColumnName("internalComment").IsOptional();

            // Ignored Properties
            this.Ignore(d => d.Type);
        }
    }
}
