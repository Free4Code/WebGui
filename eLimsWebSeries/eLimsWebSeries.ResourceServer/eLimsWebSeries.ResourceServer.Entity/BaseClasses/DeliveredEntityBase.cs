// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredEntityBase.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.BaseClasses
{
    using System;

    public abstract class DeliveredEntityBase : EntityBase
    {
        public string Version { get; set; }

        public DateTime StartingValidityDate { get; set; }

        public DateTime EndingValidityDate { get; set; }
    }
}
