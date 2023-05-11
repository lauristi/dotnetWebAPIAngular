using AutoMapper;
using webapi.Business.Models.BrazilianFloraAPI;
using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrazilianFloraAPI;

namespace webapi.Mapping
{
    public class BrazilianFloraMapping : Profile
    {
        public BrazilianFloraMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));

            CreateMap<FamilyResponseDTO, FamilyResponse>();
            CreateMap<FamilyResponse, FamilyResponseDTO>();

            CreateMap<GenusResponseDTO, GenusResponse>();
            CreateMap<GenusResponse, GenusResponseDTO>();

            CreateMap<SpeciesResponseDTO, SpeciesResponse>();
            CreateMap<SpeciesResponse, SpeciesResponseDTO>();
            //----------------------------------------
            CreateMap<SpeciesResultDTO, SpeciesResult>();
            CreateMap<SpeciesResult, SpeciesResultDTO>();

            CreateMap<TaxonResponseDTO, TaxonResponse>();
            CreateMap<TaxonResponse, TaxonResponseDTO>();
            //----------------------------------------
            CreateMap<TaxonResultDTO, TaxonResult>();
            CreateMap<TaxonResult, TaxonResultDTO>();

            CreateMap<EndemismResponseDTO, EndemismResponse>();
            CreateMap<EndemismResponse, EndemismResponseDTO>();
        }
    }
}