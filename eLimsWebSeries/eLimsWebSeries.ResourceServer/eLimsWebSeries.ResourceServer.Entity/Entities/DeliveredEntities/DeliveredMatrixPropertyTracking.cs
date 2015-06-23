// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixPropertyTracking.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;

    public sealed class DeliveredMatrixPropertyTracking : StateTrackingBase
    {
        #region Linked Properties

        public Guid MatrixPropertyId { get; set; }

        public DeliveredMatrixProperty MatrixProperty { get; set; }

        #endregion
    }
}
