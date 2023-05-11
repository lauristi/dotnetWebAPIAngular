using AutoMapper;
using webapi.Business.Interface;
using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrazilianFloraAPI;
using webapi.Services.Interfaces.BrazilianFloraService;

namespace webapi.Services.BrazilianFloraService
{
    public class BrazilianFloraService : IBrazilianFloraService
    {
        private readonly IMapper _mapper;
        private readonly IBrazilianFloraApiBLL _brasilianFloraApiBLL;

        public BrazilianFloraService(IMapper mapper, IBrazilianFloraApiBLL brasilianFloraApiBLL)
        {
            _mapper = mapper;
            _brasilianFloraApiBLL = brasilianFloraApiBLL;
        }

        public async Task<ResponseGenerico<FamilyResponseDTO>> GetFamilies()
        {
            var families = await _brasilianFloraApiBLL.GetFamilies();

            return _mapper.Map<ResponseGenerico<FamilyResponseDTO>>(families);
        }

        public async Task<ResponseGenerico<GenusResponseDTO>> GetGenus(string family)
        {
            var genus = await _brasilianFloraApiBLL.GetGenus(family);

            return _mapper.Map<ResponseGenerico<GenusResponseDTO>>(genus);
        }

        public async Task<ResponseGenerico<SpeciesResponseDTO>> GetSpecies(string family)
        {
            var species = await _brasilianFloraApiBLL.GetSpecies(family);

            return _mapper.Map<ResponseGenerico<SpeciesResponseDTO>>(species);
        }

        public async Task<ResponseGenerico<TaxonResponseDTO>> GetTaxon(string scientificName)
        {
            var taxon = await _brasilianFloraApiBLL.GetTaxon(scientificName);

            return _mapper.Map<ResponseGenerico<TaxonResponseDTO>>(taxon);
        }
    }
}