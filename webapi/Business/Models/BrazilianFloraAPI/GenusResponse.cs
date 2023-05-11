using Newtonsoft.Json;

namespace webapi.Business.Models.BrazilianFloraAPI
{
    public class GenusResponse
    {
        public bool success { get; set; }

        public List<string> result { get; set; }
    }
}
