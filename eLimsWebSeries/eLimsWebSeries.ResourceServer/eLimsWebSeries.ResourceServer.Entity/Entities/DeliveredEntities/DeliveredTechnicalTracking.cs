// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredTechnicalTracking.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;

    public sealed class DeliveredTechnicalTracking : EntityBase
    {
        #region Public Properties

        public string Entity { get; set; }

        public string Field { get; set; }

        public string ValueBefore { get; set; }

        public string ValueAfter { get; set; }

        #endregion

        #region Linked Properties

        public Guid TrackingIdId { get; set; }

        public DeliveredTracking Tracking { get; set; }

        #endregion
    }
}
