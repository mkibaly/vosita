using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace vosita_backend_task.Locations
{
    public class UserLocation : FullAuditedAggregateRoot<Guid>
    {
        public string LocationName { get; private set; }
        public LocationTypeEnum LocationType { get; private set; }
        public string? Description { get; private set; }
        [Column(TypeName = "geometry")]
        public Point LocationCoordinates { get; private set; }
        public string MainAddress { get; private set; }
        public string? SecondAddress { get; private set; }
        public Guid StateId { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
        public string MainPhoneNumber { get; private set; }

        private UserLocation()
        {
            /* This constructor is for deserialization / ORM purpose */
        }

        public UserLocation(string locationName,
            LocationTypeEnum locationType,
            string? description,
            Point locationCoordinates,
            string mainAddress,
            string? secondAddress,
            Guid stateId,
            string city,
            string zipCode,
            string mainPhoneNumber)
        {
            LocationName = locationName;
            LocationType = locationType;
            Description = description;
            LocationCoordinates = locationCoordinates;
            MainAddress = mainAddress;
            SecondAddress = secondAddress;
            StateId = stateId;
            City = city;
            ZipCode = zipCode;
            MainPhoneNumber = mainPhoneNumber;
        }
    }

}
