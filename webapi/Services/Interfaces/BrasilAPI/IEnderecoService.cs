using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrasilAPI;

namespace webapi.Services.Interfaces.BrasilAPI
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponseDTO>> BuscarEndereco(string cep);
    }
}