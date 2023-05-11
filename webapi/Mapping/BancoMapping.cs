using AutoMapper;
using webapi.Business.Models.BrasilAPI;
using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrasilAPI;

namespace webapi.Mapping
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoReponseDTO, BancoResponse>();
            CreateMap<BancoResponse, BancoReponseDTO>();
        }
    }
}