using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System;
using System.Threading.Tasks;
using System.Threading;

namespace vosita_backend_task.Locations
{
    public interface IUserLocationsAppService
    {
        Task<UserLocationDto> CreateAsync(UserLocationCreateDto location, CancellationToken cancellationToken);
        Task<UserLocationDto> GetAsync(Guid Id, CancellationToken cancellationToken);
    }

}