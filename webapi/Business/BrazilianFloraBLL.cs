using System.Dynamic;
using webapi.Business.Interface;
using webapi.Business.Models.BrazilianFloraAPI;
using webapi.Domain.GenericResponse;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace webapi.Business
{
    public class BrazilianFloraApiBLL : IBrazilianFloraApiBLL
    {
        private string LimpaJson(string json)
        {
            //----------------------------------------------------------------------------------
            //Recupero Json Sujo e limpo ele. Final do json sujo com ip pq quem fez é um imbecil
            //----------------------------------------------------------------------------------
            string dirtJson = json;
            string clearJson = dirtJson.Substring(0, dirtJson.IndexOf("Conectado com:")).Trim();
            //----------------------------------------------------------------------------------
            return clearJson;
        }

        //===========================================================
        // https://servicos.jbrj.gov.br/flora/
        //          Aizoaceae
        //===========================================================

        //Families ------------------------------------
        public async Task<ResponseGenerico<FamilyResponse>> GetFamilies()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://servicos.jbrj.gov.br/flora/families");
            var response = new ResponseGenerico<FamilyResponse>();

            using (var client = new HttpClient())
            {
                var apiResponse = await client.SendAsync(request);
                var apiResponseContent = await apiResponse.Content.ReadAsStringAsync();

                string clearJson = LimpaJson(apiResponse.Content.ReadAsStringAsync().Result);

                var apiResponseObject = JsonSerializer.Deserialize<FamilyResponse>(clearJson);

                if (apiResponse.IsSuccessStatusCode)
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.DadosRetorno = apiResponseObject;
                }
                else
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(apiResponseContent);
                }
            }

            return response;
        }

        //Genus ---------------------------------------
        public async Task<ResponseGenerico<GenusResponse>> GetGenus(string family)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://servicos.jbrj.gov.br/flora/genus/{family}");
            var response = new ResponseGenerico<GenusResponse>();

            using (var client = new HttpClient())
            {
                var apiResponse = await client.SendAsync(request);
                var apiResponseContent = await apiResponse.Content.ReadAsStringAsync();

                string clearJson = LimpaJson(apiResponse.Content.ReadAsStringAsync().Result);

                var apiResponseObject = JsonSerializer.Deserialize<GenusResponse>(clearJson);

                if (apiResponse.IsSuccessStatusCode)
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.DadosRetorno = apiResponseObject;
                }
                else
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(apiResponseContent);
                }
            }

            return response;
        }

        //Species -------------------------------------
        public async Task<ResponseGenerico<SpeciesResponse>> GetSpecies(string family)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://servicos.jbrj.gov.br/flora/species/{family}");
            var response = new ResponseGenerico<SpeciesResponse>();

            using (var client = new HttpClient())
            {
                var apiResponse = await client.SendAsync(request);
                var apiResponseContent = await apiResponse.Content.ReadAsStringAsync();

                string clearJson = LimpaJson(apiResponse.Content.ReadAsStringAsync().Result);

                var apiResponseObject = JsonSerializer.Deserialize<SpeciesResponse>(clearJson);

                if (apiResponse.IsSuccessStatusCode)
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.DadosRetorno = apiResponseObject;
                }
                else
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(apiResponseContent);
                }
            }

            return response;
        }

        //Taxon ---------------------------------------
        public async Task<ResponseGenerico<TaxonResponse>> GetTaxon(string scientificName)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://servicos.jbrj.gov.br/flora/taxon/{scientificName}");
            var response = new ResponseGenerico<TaxonResponse>();

            using (var client = new HttpClient())
            {
                var apiResponse = await client.SendAsync(request);
                var apiResponseContent = await apiResponse.Content.ReadAsStringAsync();

                string clearJson = LimpaJson(apiResponse.Content.ReadAsStringAsync().Result);

                var apiResponseObject = JsonSerializer.Deserialize<TaxonResponse>(clearJson);

                if (apiResponse.IsSuccessStatusCode)
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.DadosRetorno = apiResponseObject;
                }
                else
                {
                    response.CodigoHttp = apiResponse.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(apiResponseContent);
                }
            }

            return response;
        }

        //Endemism ------------------------------------
        public Task<ResponseGenerico<EndemismResponse>> GetEndemism(string scientificName)
        {
            throw new NotImplementedException();
        }
    }
}