using AutoMapper;
using webapi.Business.Models.BrasilAPI;
using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrasilAPI;

namespace webapi.Mapping
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponseDTO, EnderecoResponse>();
            CreateMap<EnderecoResponse, EnderecoResponseDTO>();
        }
    }
}