using NetTopologySuite.Geometries;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Volo.Abp.Threading;

namespace vosita_backend_task.Locations
{
    public class UserLocationCreateDto
    {
        [Required]
        [StringLength(UserLocationConsts.MaxNameLength)] 
        public string LocationName { get; set; }

        [Required]
        public LocationTypeEnum LocationType { get; set; }

        [StringLength(UserLocationConsts.MaxDiscriptionLength)]
        public string? Description { get; set; }
        
        [Required]
        public PointDto LocationCoordinates { get; set; }

        [Required]
        [StringLength(UserLocationConsts.MaxAddressLength)]
        public string MainAddress { get; set; }

        [StringLength(UserLocationConsts.MaxAddressLength)]
        public string? SecondAddress { get; set; }

        [Required]
        public Guid StateId { get; set; }
        
        [Required]
        [StringLength(UserLocationConsts.MaxCityLength)]
        public string City { get; set; }
        
        [Required]
        [StringLength(UserLocationConsts.MaxZipCodeLength)]
        public string ZipCode { get; set; }
        
        [Required]
        [StringLength(UserLocationConsts.MaxPhoneLength)]
        public string MainPhoneNumber { get; set; }

    }
}