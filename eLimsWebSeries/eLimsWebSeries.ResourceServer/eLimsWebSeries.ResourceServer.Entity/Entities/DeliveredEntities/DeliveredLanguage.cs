// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredLanguage.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System.Collections.Generic;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DeliveredLanguage : EntityBase, ILanguageEntity, IEntityWithTranslations<DeliveredLanguageTranslation, DeliveredLanguage>
    {
        #region Constructor

        public DeliveredLanguage()
        {
            this.Translations = new List<DeliveredLanguageTranslation>();
        }

        #endregion

        #region Public Properties

        public string IsoCode { get; set; }

        public string InternalName { get; set; }

        #endregion

        #region Linked Properties

        public ICollection<DeliveredLanguageTranslation> Translations { get; set; }

        #endregion
    }
}