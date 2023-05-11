using AutoMapper;
using webapi.Business.Interface;
using webapi.Domain.GenericResponse;
using webapi.Services.DTO.BrasilAPI;
using webapi.Services.Interfaces.BrasilAPI;

namespace webapi.Services.BrasilAPI
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApiBLL _brasilApiBLL;

        public BancoService(IMapper mapper, IBrasilApiBLL brasilApiBLL)
        {
            _mapper = mapper;
            _brasilApiBLL = brasilApiBLL;
        }

        public async Task<ResponseGenerico<List<BancoReponseDTO>>> BuscarTodos()
        {
            var bancos = await _brasilApiBLL.BuscarTodosBancos();
            return _mapper.Map<ResponseGenerico<List<BancoReponseDTO>>>(bancos);
        }

        public async Task<ResponseGenerico<BancoReponseDTO>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApiBLL.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoReponseDTO>>(banco);
        }
    }
}