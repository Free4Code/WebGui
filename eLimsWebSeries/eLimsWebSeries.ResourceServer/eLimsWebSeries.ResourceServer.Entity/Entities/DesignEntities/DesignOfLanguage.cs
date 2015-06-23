// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfLanguage.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities
{
    using System.Collections.Generic;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DesignOfLanguage : EntityBase, ILanguageEntity, IEntityWithTranslations<DesignOfLanguageTranslation, DesignOfLanguage>
    {
        #region Constructor

        public DesignOfLanguage()
        {
            this.Translations = new List<DesignOfLanguageTranslation>();
        }

        #endregion

        #region Public Properties

        public string IsoCode { get; set; }

        public string InternalName { get; set; }

        #endregion

        #region Linked Properties

        public ICollection<DesignOfLanguageTranslation> Translations { get; set; }

        #endregion
    }
}