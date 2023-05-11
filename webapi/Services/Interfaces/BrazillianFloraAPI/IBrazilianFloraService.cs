using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrazilianFloraAPI;

namespace webapi.Services.Interfaces.BrazilianFloraService
{
    public interface IBrazilianFloraService
    {
        Task<ResponseGenerico<FamilyResponseDTO>> GetFamilies();

        Task<ResponseGenerico<GenusResponseDTO>> GetGenus(string family);

        Task<ResponseGenerico<SpeciesResponseDTO>> GetSpecies(string family);

        Task<ResponseGenerico<TaxonResponseDTO>> GetTaxon(string scientificName);

        //Task<ResponseGenerico<EndemismResponse>> GetEndemism(string scientificName);

        //Task<ResponseGenerico<UrlResponse>> GetUrl(string specie);

        //Task<ResponseGenerico<SearcheResponse>> GetSearch(string scientificName);
    }
}