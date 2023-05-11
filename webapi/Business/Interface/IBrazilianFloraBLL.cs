using webapi.Business.Models.BrazilianFloraAPI;
using webapi.Domain.GenericResponse;

namespace webapi.Business.Interface
{
    public interface IBrazilianFloraApiBLL
    {
        Task<ResponseGenerico<FamilyResponse>> GetFamilies();

        Task<ResponseGenerico<GenusResponse>> GetGenus(string family);

        Task<ResponseGenerico<SpeciesResponse>> GetSpecies(string family);

        Task<ResponseGenerico<TaxonResponse>> GetTaxon(string scientificName);

        Task<ResponseGenerico<EndemismResponse>> GetEndemism(string scientificName);

        //Task<ResponseGenerico<UrlResponse>> GetUrl(string specie);

        //Task<ResponseGenerico<SearcheResponse>> GetSearch(string scientificName);
    }
}