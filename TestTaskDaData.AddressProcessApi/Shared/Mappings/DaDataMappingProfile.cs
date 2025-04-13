using AutoMapper;
using TestTaskDaData.AddressProcessApi.Shared.Models;

namespace TestTaskDaData.AddressProcessApi.Shared.Mappings;

public class DaDataResponseMappingProfile : Profile
{
    public DaDataResponseMappingProfile()
    {
        CreateMap<DaDataResponse, ProcessedAddress>()
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
            .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Street))
            .ForMember(dest => dest.House, opt => opt.MapFrom(src => src.House));
    }
}