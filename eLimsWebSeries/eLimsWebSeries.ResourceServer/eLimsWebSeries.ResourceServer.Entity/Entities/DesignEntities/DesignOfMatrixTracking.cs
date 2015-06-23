// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixTracking.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;

    public sealed class DesignOfMatrixTracking : StateTrackingBase
    {
        #region Linked Properties

        public Guid MatrixId { get; set; }

        public DesignOfMatrix Matrix { get; set; }

        #endregion
    }
}