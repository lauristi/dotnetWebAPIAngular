using Newtonsoft.Json;

namespace webapi.Services.DTO.BrazilianFloraAPI
{
    public class TaxonResponseDTO
    {
        [JsonProperty("success")]
        public bool success { get; set; }

        [JsonProperty("result")]
        public List<TaxonResultDTO> result { get; set; }
    }

    public class TaxonResultDTO
    {
        [JsonProperty("taxonid")]
        public string taxonid { get; set; }

        [JsonProperty("family")]
        public string family { get; set; }

        [JsonProperty("genus")]
        public string genus { get; set; }

        [JsonProperty("scientificname")]
        public string scientificname { get; set; }

        [JsonProperty("specificepithet")]
        public string specificepithet { get; set; }

        [JsonProperty("infraspecificepithet")]
        public object infraspecificepithet { get; set; }

        [JsonProperty("scientificnameauthorship")]
        public string scientificnameauthorship { get; set; }

        [JsonProperty("taxonomicstatus")]
        public string taxonomicstatus { get; set; }

        [JsonProperty("acceptednameusage")]
        public string acceptednameusage { get; set; }

        [JsonProperty("higherclassification")]
        public string higherclassification { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("references")]
        public string references { get; set; }

        [JsonProperty("acceptednameusageid")]
        public string acceptednameusageid { get; set; }

        [JsonProperty("modified")]
        public string modified { get; set; }

        [JsonProperty("NOME ACEITO")]
        public List<NomeAceitoDTO> NOMEACEITO { get; set; }
    }

    public class NomeAceitoDTO
    {
        [JsonProperty("taxonid")]
        public string taxonid { get; set; }

        [JsonProperty("family")]
        public string family { get; set; }

        [JsonProperty("genus")]
        public string genus { get; set; }

        [JsonProperty("scientificname")]
        public string scientificname { get; set; }

        [JsonProperty("specificepithet")]
        public string specificepithet { get; set; }

        [JsonProperty("infraspecificepithet")]
        public object infraspecificepithet { get; set; }

        [JsonProperty("scientificnameauthorship")]
        public string scientificnameauthorship { get; set; }

        [JsonProperty("taxonomicstatus")]
        public string taxonomicstatus { get; set; }

        [JsonProperty("acceptednameusage")]
        public object acceptednameusage { get; set; }

        [JsonProperty("higherclassification")]
        public string higherclassification { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("references")]
        public string references { get; set; }
    }
}