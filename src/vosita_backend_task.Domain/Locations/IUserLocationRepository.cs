using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace vosita_backend_task.Locations
{
    public interface IUserLocationRepository : IRepository<UserLocation, Guid>
    {
        Task<List<UserLocation>> GetListAsync(string LocationName, LocationTypeEnum? locationType, string City, string ZipCode, int skipCount, int maxResultCount, CancellationToken cancellationToken);
        Task<long> GetListCountAsync(string LocationName, LocationTypeEnum? locationType, string City, string ZipCode, CancellationToken cancellationToken);
    }
}
