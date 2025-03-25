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
                .ForMember(book => book.Id, opt => opt.Ignore())
                .ForMember(book => book.Uuid, opt => opt.MapFrom(src => Guid.Parse(src.Uuid)))
                .ForMember(book => book.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(book => book.Author, opt => opt.MapFrom(src => src.Author))
                .ForMember(book => book.Summary, opt => opt.MapFrom(src => src.Summary))
                .ForMember(book => book.PublishDate, opt => opt.MapFrom(src => src.PublishDate))
                .ForMember(book => book.Quantity, opt => opt.MapFrom(src => src.Quantity));
        }
    }
}