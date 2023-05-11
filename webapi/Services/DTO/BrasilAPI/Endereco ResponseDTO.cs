using System.Text.Json.Serialization;

namespace webapi.Services.DTO.BrasilAPI
{
    public class EnderecoResponseDTO
    {
        public string? Cep { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Regiao { get; set; }
        public string? Rua { get; set; }

        [JsonIgnore] // Nao retorna para o usuario no consumo
        public string? Servico { get; set; }
    }
}