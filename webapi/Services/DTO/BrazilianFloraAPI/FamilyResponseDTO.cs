using Newtonsoft.Json;

namespace webapi.Services.DTO.BrazilianFloraAPI
{
    public class FamilyResponseDTO
    {
        [JsonProperty("success")]
        public bool success { get; set; }

        [JsonProperty("result")]
        public List<string> result { get; set; }
    }
}