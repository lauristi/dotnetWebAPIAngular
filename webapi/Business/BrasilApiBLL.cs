using System.Dynamic;
using System.Text.Json;
using webapi.Business.Interface;
using webapi.Business.Models.BrasilAPI;
using webapi.Domain.GenericResponse;

namespace webapi.Business
{
    public class BrasilApiBLL : IBrasilApiBLL
    {
        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCEP(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
            var response = new ResponseGenerico<EnderecoResponse>();

            using (var client = new HttpClient())
            {
                var apiResponse = await client.SendAsync(request);
                var apiResponseContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseObject = JsonSerializer.Deserialize<EnderecoResponse>(apiResponseContent);

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

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
            var response = new ResponseGenerico<List<BancoResponse>>();

            using (var client = new HttpClient())
            {
                var apiResponse = await client.SendAsync(request);
                var apiResponseContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseObject = JsonSerializer.Deserialize<List<BancoResponse>>(apiResponseContent);

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

        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");
            var response = new ResponseGenerico<BancoResponse>();

            using (var client = new HttpClient())
            {
                var apiResponse = await client.SendAsync(request);
                var apiResponseContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseObject = JsonSerializer.Deserialize<BancoResponse>(apiResponseContent);

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
    }
}