﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfLanguageMap.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Maps.DesignMaps
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    /// <summary>
    /// The design of language map.
    /// </summary>
    public sealed class DesignOfLanguageMap : EntityTypeConfiguration<DesignOfLanguage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignOfLanguageMap"/> class.
        /// </summary>
        public DesignOfLanguageMap()
        {
            // table name
            this.ToTable("designOfLanguages");

            // Keys
            this.HasKey(t => t.Id);
            this.Property(d => d.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("designOfLanguageId");

            // Relationship
            this.HasMany(d => d.Translations)
                .WithOptional(t => t.TranslatedLanguage)
                .HasForeignKey(t => t.TranslatedLanguageId);

            // Other configurations
            this.Property(d => d.RowVersion).HasColumnName("rowVersion").IsRowVersion();

            // Required Properties
            this.Property(d => d.IsoCode).HasColumnName("isoCode").IsRequired();
            this.Property(d => d.InternalName).HasColumnName("internalName").IsRequired();

            // Optional Properties

            // Ignored Properties
        }
    }
}