// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityBase.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.BaseClasses
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using Repository.Pattern.Infrastructure;

    public abstract class EntityBase : IObjectState
    {
        public Guid Id { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
