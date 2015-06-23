// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfUserInterfaceTagTranslation.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.NotImplemented
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfUserInterfaceTagTranslation : EntityBase
    {
        #region Public Properties

        public string TranslatedName { get; set; }

        #endregion

        #region Linked Properties

        public Guid TranslatedUserInterfaceTagId { get; set; }

        public DesignOfUserInterfaceTag TranslatedUserInterfaceTag { get; set; }

        public Guid LanguageId { get; set; }

        public DesignOfLanguage Language { get; set; }

        #endregion
    }
}