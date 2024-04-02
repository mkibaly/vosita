using Volo.Abp.Application.Dtos;

namespace vosita_backend_task.Locations
{
    public class UserLocationFilterDto : PagedResultRequestDto
    {
        public string? LocationName { get; set; }
        public LocationTypeEnum? LocationType { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
    }


}