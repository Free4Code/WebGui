﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixTranslation.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DeliveredMatrixTranslation : DeliveredEntityBase, ITranslatedEntity<DeliveredLanguage>
    {
        #region Public Properties

        public string TranslatedName { get; set; }

        public string TranslatedComment { get; set; }

        #endregion

        #region Linked Properties

        public Guid TranslatedMatrixId { get; set; }

        public DeliveredMatrix TranslatedMatrix { get; set; }

        public Guid LanguageId { get; set; }

        public DeliveredLanguage Language { get; set; }

        #endregion
    }
}
