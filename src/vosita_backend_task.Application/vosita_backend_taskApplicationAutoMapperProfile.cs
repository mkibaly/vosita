using AutoMapper;
using vosita_backend_task.Locations;

namespace vosita_backend_task;

public class vosita_backend_taskApplicationAutoMapperProfile : Profile
{
    public vosita_backend_taskApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        //this.CreateMap<NetTopologySuite.Geometries.Point, PointDto>()
        //    .ForMember(dis => dis.Lat, opt => opt.MapFrom(src => src.X))
        //    .ForMember(dis => dis.Long, opt => opt.MapFrom(src => src.Y))
        //    .ReverseMap();
        CreateMap<UserLocation, UserLocationDto>();
        
        CreateMap<PointDto, NetTopologySuite.Geometries. Point>()
            .ConstructUsing(dto => dto.GetPoint());
        CreateMap<NetTopologySuite.Geometries.Point, PointDto>()
            .ConstructUsing(p => new PointDto(p));
    }
}
