// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TranslatedEntityQuery.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Queries
{
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    using Repository.Pattern.Ef6;

    public sealed class TranslatedEntityQuery<T> : QueryObject<ITranslatedEntity<T>>
        where T : ILanguageEntity
    {
        public TranslatedEntityQuery<T> WithTranslatedEntity(string languageIsoCode)
        {
            this.And(
                entity =>
                entity.Language.IsoCode == languageIsoCode);
            return this;
        }
    }
}