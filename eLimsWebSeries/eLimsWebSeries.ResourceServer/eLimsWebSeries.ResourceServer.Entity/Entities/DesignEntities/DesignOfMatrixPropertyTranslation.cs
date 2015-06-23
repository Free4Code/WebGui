// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyTranslation.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DesignOfMatrixPropertyTranslation : EntityBase, ITranslatedEntity<DesignOfLanguage>
    {
        #region Public Properties

        public string TranslatedName { get; set; }

        public string TranslatedComment { get; set; }

        #endregion

        #region Linked Properties

        public Guid TranslatedMatrixPropertyId { get; set; }

        public DesignOfMatrixProperty TranslatedMatrixProperty { get; set; }

        public Guid LanguageId { get; set; }

        public DesignOfLanguage Language { get; set; }

        #endregion
    }
}