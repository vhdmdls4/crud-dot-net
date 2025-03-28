using AutoMapper;
using crud_dot_net.DTO;
using crud_dot_net.Models;

namespace crud_dot_net.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        {
            CreateMap<CreateBookRequest, Book>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Uuid, opt => opt.MapFrom(_ => Guid.NewGuid()));
        }
    }
}