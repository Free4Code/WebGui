// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeliveredEntityQuery.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Queries
{
    using System;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;

    using Repository.Pattern.Ef6;

    public sealed class DeliveredEntityQuery : QueryObject<DeliveredEntityBase>
    {
        public DeliveredEntityQuery WithValidEntity(DateTime checkDate)
        {
            this.And(
                deliveredEntity =>
                deliveredEntity.EndingValidityDate > checkDate && deliveredEntity.StartingValidityDate < checkDate);
            return this;
        }
    }
}

