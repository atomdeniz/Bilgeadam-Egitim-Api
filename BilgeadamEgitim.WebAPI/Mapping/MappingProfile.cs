using AutoMapper;
using BilgeadamEgitim.Common.DTO;
using BilgeadamEgitim.Core.Models;

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
