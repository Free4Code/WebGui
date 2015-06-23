// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixPropertyChoice.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;
    using System.Collections.Generic;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    public sealed class DeliveredMatrixPropertyChoice : DeliveredEntityBase, IEntityWithTranslations<DeliveredMatrixPropertyChoiceTranslation, DeliveredLanguage>
    {
        #region Public Properties

        public string InternalName { get; set; }

        #endregion

        #region Linked Properties

        public Guid MatrixPropertyId { get; set; }

        public DeliveredMatrixProperty MatrixProperty { get; set; }

        public ICollection<DeliveredMatrixPropertyChoiceTranslation> Translations { get; set; }

        #endregion
    }
}
