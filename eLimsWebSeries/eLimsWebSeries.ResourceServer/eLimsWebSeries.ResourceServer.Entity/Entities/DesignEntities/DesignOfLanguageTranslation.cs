// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfLanguageTranslation.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DesignOfLanguageTranslation : EntityBase, ITranslatedEntity<DesignOfLanguage>
    {
        #region Public Properties

        public string TranslatedName { get; set; }

        #endregion

        #region Linked Properties

        public Guid TranslatedLanguageId { get; set; }

        public DesignOfLanguage TranslatedLanguage { get; set; }

        public Guid LanguageId { get; set; }

        public DesignOfLanguage Language { get; set; }

        #endregion
    }
}