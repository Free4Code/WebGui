// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyChoice.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities
{
    using System;
    using System.Collections.Generic;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DesignOfMatrixPropertyChoice : EntityBase, IEntityWithTranslations<DesignOfMatrixPropertyChoiceTranslation, DesignOfLanguage>
    {
        #region Public Properties

        public string InternalName { get; set; }

        #endregion

        #region Linked Properties

        public Guid MatrixPropertyId { get; set; }

        public DesignOfMatrixProperty MatrixProperty { get; set; }

        public ICollection<DesignOfMatrixPropertyChoiceTranslation> Translations { get; set; }

        #endregion
    }
}