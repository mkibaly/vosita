using System;
using System.Threading.Tasks;
using System.Threading;
using Volo.Abp.Application.Dtos;

namespace vosita_backend_task.Locations
{
    public interface IUserLocationsAppService
    {
        Task<UserLocationDto> CreateAsync(Guid? id, UserLocationCreateDto location, CancellationToken cancellationToken);
        Task<UserLocationDto> GetAsync(Guid Id, CancellationToken cancellationToken);
        Task<PagedResultDto<UserLocationDto>> GetListAsync(UserLocationFilterDto filter, CancellationToken cancellationToken);
    }

}