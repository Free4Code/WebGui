// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEntityWithTranslations.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Entity.Interfaces
{
    using System.Collections.Generic;

    public interface IEntityWithTranslations<T, U>
        where T : ITranslatedEntity<U>
        where U : ILanguageEntity
    {
        ICollection<T> Translations { get; }
    }
}
