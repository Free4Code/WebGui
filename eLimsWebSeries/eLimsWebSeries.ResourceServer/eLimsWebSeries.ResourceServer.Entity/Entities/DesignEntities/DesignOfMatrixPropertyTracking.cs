// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixPropertyTracking.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;

    public sealed class DesignOfMatrixPropertyTracking : StateTrackingBase
    {
        #region Linked Properties

        public Guid MatrixPropertyId { get; set; }

        public DesignOfMatrixProperty MatrixProperty { get; set; }

        #endregion
    }
}