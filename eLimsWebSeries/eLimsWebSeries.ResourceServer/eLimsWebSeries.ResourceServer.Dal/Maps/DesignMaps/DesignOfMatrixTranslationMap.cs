﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixTranslationMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfMatrixTranslationMap : EntityTypeConfiguration<DesignOfMatrixTranslation>
    {
        public DesignOfMatrixTranslationMap()
        {
            // table name
            this.ToTable("designOfMatrixTranslations");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfMatrixTranslationId");

            // Relationship
            this.HasRequired(d => d.TranslatedMatrix).WithMany().HasForeignKey(d => d.TranslatedMatrixId);
            this.HasRequired(d => d.Language).WithMany().HasForeignKey(d => d.LanguageId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.TranslatedName).HasColumnName("translatedName").IsRequired();

            // Optional Properties
            this.Property(d => d.TranslatedComment).HasColumnName("translatedComment").IsOptional();

            // Ignored Properties
        }
    }
}