// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredMatrixTracking.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;

    public sealed class DeliveredMatrixTracking : StateTrackingBase
    {
        #region Linked Properties

        public Guid MatrixId { get; set; }

        public DeliveredMatrix Matrix { get; set; }

        #endregion
    }
}
