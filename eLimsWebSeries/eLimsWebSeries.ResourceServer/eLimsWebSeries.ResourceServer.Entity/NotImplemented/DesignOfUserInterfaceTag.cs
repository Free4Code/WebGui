// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfUserInterfaceTag.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.NotImplemented
{
    using System.Collections.Generic;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    public sealed class DesignOfUserInterfaceTag
    {
        #region Constructor

        public DesignOfUserInterfaceTag()
        {
            this.Translations = new List<DesignOfUserInterfaceTagTranslation>();
        }

        #endregion

        #region Public Properties

        public string Package { get; set; }

        public string Functionnality { get; set; }

        public string Tag { get; set; }

        #endregion

        #region Linked Properties

        public ICollection<DesignOfUserInterfaceTagTranslation> Translations { get; set; }

        #endregion
    }
}