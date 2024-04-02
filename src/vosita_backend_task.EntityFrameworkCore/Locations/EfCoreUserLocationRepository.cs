using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
      
    }
}
