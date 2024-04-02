using NetTopologySuite.Geometries;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace vosita_backend_task.Locations
{
    public class UserLocation : FullAuditedAggregateRoot<Guid>
    {
        public string LocationName { get; private set; }
        public LocationTypeEnum LocationType { get; private set; }
        public string? Description { get; private set; }
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

            #region validation  

            // Validate required parameters
            if (string.IsNullOrEmpty(locationName))
            {
                throw new UserFriendlyException("Location name is required.");
            }

            // Validate the LocationTypeEnum
            if (!Enum.IsDefined(typeof(LocationTypeEnum), locationType))
            {
                throw new UserFriendlyException("Invalid location type.");
            }

            if (locationCoordinates == null || locationCoordinates.IsEmpty)
            {
                throw new UserFriendlyException("Location coordinates are required.");
            }

            if (string.IsNullOrEmpty(mainAddress))
            {
                throw new UserFriendlyException("Main address is required.");
            }

            if (stateId == Guid.Empty)
            {
                throw new UserFriendlyException("State ID is required.");
            }

            if (string.IsNullOrEmpty(city))
            {
                throw new UserFriendlyException("City is required.");
            }

            if (string.IsNullOrEmpty(zipCode))
            {
                throw new UserFriendlyException("Zip code is required.");
            }

            if (string.IsNullOrEmpty(mainPhoneNumber))
            {
                throw new UserFriendlyException("Main phone number is required.");
            }

            #endregion

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
