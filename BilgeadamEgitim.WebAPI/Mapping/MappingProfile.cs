using AutoMapper;
using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.WebAPI.DTO;

namespace BilgeadamEgitim.WebAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Content, ContentResponseDTO>();
            CreateMap<ContentDTO, Content>();

        }
    }
}
