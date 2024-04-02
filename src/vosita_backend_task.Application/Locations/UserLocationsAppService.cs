using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace vosita_backend_task.Locations
{
    public class UserLocationsAppService : vosita_backend_taskAppService, IUserLocationsAppService
    {
        private readonly IUserLocationRepository _userLocationRepository;

        public UserLocationsAppService(IUserLocationRepository userLocationRepository)
        {
            _userLocationRepository = userLocationRepository;
        }

        public async Task<UserLocationDto> CreateAsync(UserLocationCreateDto location, CancellationToken cancellationToken)
        {
            var userLocation = new UserLocation(location.LocationName,
                location.LocationType,
                location.Description,
                location.LocationCoordinates.GetPoint(),
                location.MainAddress,
                location.SecondAddress,
                location.StateId,
                location.City,
                location.ZipCode,
                location.MainPhoneNumber);

            var insertedLocation = await _userLocationRepository.InsertAsync(userLocation, false, cancellationToken);
            var dto = ObjectMapper.Map<UserLocation, UserLocationDto>(insertedLocation);
            return dto;
        }

        public async Task<UserLocationDto> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            var location = await _userLocationRepository.FindAsync(id, true, cancellationToken);

            if (location == null)
            {
                throw new UserFriendlyException("Can't find user location");
            }

            var dto = ObjectMapper.Map<UserLocation, UserLocationDto>(location);
            return dto;
        }

        public async Task<PagedResultDto<UserLocationDto>> GetListAsync(UserLocationFilterDto filter, CancellationToken cancellationToken)
        {
            var list = await _userLocationRepository.GetListAsync(filter.LocationName, filter.LocationType, filter.City, filter.ZipCode, filter.SkipCount, filter.MaxResultCount, cancellationToken);
            var count = await _userLocationRepository.GetListCountAsync(filter.LocationName, filter.LocationType, filter.City, filter.ZipCode, cancellationToken);

            var result = new PagedResultDto<UserLocationDto>()
            {
                Items = ObjectMapper.Map<List<UserLocation>, List<UserLocationDto>>(list),
                TotalCount = count
            };

            return result;
        }

    }
}