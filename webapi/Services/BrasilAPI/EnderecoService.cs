using AutoMapper;
using webapi.Business.Interface;
using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrasilAPI;
using webapi.Services.Interfaces.BrasilAPI;

namespace webapi.Services.BrasilAPI
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiBLL _brasilApiBLL;

        public EnderecoService(IMapper mapper, IBrasilApiBLL brasilApiBLL)
        {
            _mapper = mapper;
            _brasilApiBLL = brasilApiBLL;
        }

        public async Task<ResponseGenerico<EnderecoResponseDTO>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApiBLL.BuscarEnderecoPorCEP(cep);

            return _mapper.Map<ResponseGenerico<EnderecoResponseDTO>>(endereco);
        }
    }
}