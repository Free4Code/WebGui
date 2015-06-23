
namespace eLimsWebSeries.ResourceServer.Dal.Queries
{
    using System;
    using System.Linq;

    using eLimsWebSeries.ResourceServer.Entity.BaseClasses;
    using eLimsWebSeries.ResourceServer.Entity.Interfaces;

    using Repository.Pattern.Ef6;

    public sealed class EntityWithTranslations<T, U> : QueryObject<IEntityWithTranslations<T, U>>
        where T : ITranslatedEntity<U>
        where U : ILanguageEntity
    {
        //public EntityWithTranslations<T, U> WithTranslatedEntity2(string languageIsoCode)
        //{
        //    this.And(
        //        entity =>
        //        entity.Translations..WithTranslatedEntity);
        //    return this;
        //}
    }
}