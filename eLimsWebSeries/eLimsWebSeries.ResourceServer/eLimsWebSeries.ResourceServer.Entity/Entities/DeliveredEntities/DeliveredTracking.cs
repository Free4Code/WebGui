// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredTracking.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DeliveredEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;

    public sealed class DeliveredTracking : EntityBase
    {
        #region Public Properties

        public string Context { get; set; }
        
        public string ActionTitle { get; set; }

        public string ActionComment { get; set; }

        public DateTime ActionDate { get; set; }

        public string ActionUser { get; set; }

        #endregion
    }
}
