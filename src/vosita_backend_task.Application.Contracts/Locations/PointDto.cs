using NetTopologySuite.Geometries;

namespace vosita_backend_task.Locations
{
    public class PointDto
    {
        public PointDto(){}

        public PointDto(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public PointDto(NetTopologySuite.Geometries.Point point)
        {
            Longitude = point.X;
            Latitude = point.Y;
        }

        public NetTopologySuite.Geometries.Point GetPoint() => 
            new Point(Longitude, Latitude) { SRID = 4326 };

        public double Longitude { get; set; }

        public double Latitude { get; set; }
    }
}