using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrasilAPI;

namespace webapi.Services.Interfaces.BrasilAPI
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoReponseDTO>>> BuscarTodos();

        Task<ResponseGenerico<BancoReponseDTO>> BuscarBanco(string codigoBanco);
    }
}