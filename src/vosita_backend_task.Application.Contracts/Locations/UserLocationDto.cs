using System;
using System.Runtime.Serialization;
using Volo.Abp.Application.Dtos;

namespace vosita_backend_task.Locations
{
    public class UserLocationDto : EntityDto<Guid>
    {
        public string LocationName { get;  set; }
        public LocationTypeEnum LocationType { get;  set; }
        public string? Description { get;  set; }
        public PointDto LocationCoordinates { get;  set; }
        public string MainAddress { get;  set; }
        public string? SecondAddress { get;  set; }
        public Guid StateId { get;  set; }
        public string City { get;  set; }
        public string ZipCode { get;  set; }
        public string MainPhoneNumber { get;  set; }

    }

    
}