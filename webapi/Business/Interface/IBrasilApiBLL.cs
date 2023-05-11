using webapi.Business.Models.BrasilAPI;
using webapi.Business.Models.BrazilianFloraAPI;
using webapi.Domain.GenericResponse;

namespace webapi.Business.Interface
{
    public interface IBrasilApiBLL
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEnderecoPorCEP(string cep);

        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}