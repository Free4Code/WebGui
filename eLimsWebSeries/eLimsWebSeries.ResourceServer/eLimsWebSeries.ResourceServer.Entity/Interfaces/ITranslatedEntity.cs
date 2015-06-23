// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITranslatedEntity.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Interfaces
{
    using System;

    public interface ITranslatedEntity<T>
        where T : ILanguageEntity
    {
        Guid LanguageId { get; }

        T Language { get; }
    }
}
