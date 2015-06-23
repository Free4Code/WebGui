// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredLanguageTranslation.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DeliveredLanguageTranslation : DeliveredEntityBase, ITranslatedEntity<DeliveredLanguage>
    {
        #region Public Properties

        public string TranslatedName { get; set; }

        #endregion

        #region Linked Properties

        public Guid TranslatedLanguageId { get; set; }

        public DeliveredLanguage TranslatedLanguage { get; set; }

        public Guid LanguageId { get; set; }

        public DeliveredLanguage Language { get; set; }

        #endregion
    }
}