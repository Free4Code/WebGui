// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignOfMatrixRepository.cs" company="Emergence-I">
//   Copyright (c) Emergence-I. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace eLimsWebSeries.ResourceServer.Dal.Repositories
{
    using System.Data.Entity;
    using System.Linq;

    using eLimsWebSeries.ResourceServer.Entity.Entities.DesignEntities;

    using Repository.Pattern.Repositories;

    public static class DesignOfMatrixRepository
    {
        public static DesignOfMatrix Get(this IRepositoryAsync<DesignOfMatrix> repository, string matrixCode)
        {
            return repository
                .Queryable()
                .Include(x => x.Parent)
                .Include(x => x.MatrixPropertyValues)
                .Include(x => x.Trackings)
                .Include(x => x.Translations)
                .SingleOrDefault(x => x.Code == matrixCode);
        }
    }
}