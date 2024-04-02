using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using vosita_backend_task.EntityFrameworkCore;

namespace vosita_backend_task.Locations
{
    public class EfCoreUserLocationRepository
        : EfCoreRepository<vosita_backend_taskDbContext, UserLocation, Guid>,
            IUserLocationRepository
    {
        public EfCoreUserLocationRepository(
            IDbContextProvider<vosita_backend_taskDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<UserLocation>> GetListAsync(
            string LocationName,
            LocationTypeEnum? locationType,
            string City,
            string ZipCode,
            int skipCount,
            int maxResultCount,
            CancellationToken cancellationToken)
        {
            var query = (await GetQueryableAsync())
                .WhereIf(!string.IsNullOrWhiteSpace(LocationName), a => a.LocationName.Contains(LocationName))
                .WhereIf(locationType.HasValue && Enum.IsDefined(typeof(LocationTypeEnum), locationType), a => a.LocationType == locationType)
                .WhereIf(!string.IsNullOrWhiteSpace(City), a => a.City.Contains(City))
                .WhereIf(!string.IsNullOrWhiteSpace(ZipCode), a => a.ZipCode == ZipCode)
                .Skip(skipCount)
                .Take(maxResultCount);

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<long> GetListCountAsync(
            string LocationName,
            LocationTypeEnum? locationType,
            string City,
            string ZipCode,
            CancellationToken cancellationToken)
        {
            var query = (await GetQueryableAsync())
                .WhereIf(!string.IsNullOrWhiteSpace(LocationName), a => a.LocationName.Contains(LocationName))
                .WhereIf(locationType.HasValue && Enum.IsDefined(typeof(LocationTypeEnum), locationType), a => a.LocationType == locationType)
                .WhereIf(!string.IsNullOrWhiteSpace(City), a => a.City.Contains(City))
                .WhereIf(!string.IsNullOrWhiteSpace(ZipCode), a => a.ZipCode == ZipCode);

            return await query.LongCountAsync(cancellationToken);
        }
    }
}
