using Newtonsoft.Json;

namespace webapi.Business.Models.BrazilianFloraAPI
{
    public class FamilyResponse
    {
        public bool success { get; set; }

        public List<string> result { get; set; }
    }
}