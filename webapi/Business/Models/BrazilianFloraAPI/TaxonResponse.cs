namespace webapi.Business.Models.BrazilianFloraAPI
{
    public class TaxonResponse
    {
        public bool success { get; set; }

        public List<TaxonResult> result { get; set; }
    }

    public class TaxonResult
    {
        public string taxonid { get; set; }

        public string family { get; set; }

        public string genus { get; set; }

        public string scientificname { get; set; }

        public string specificepithet { get; set; }

        public object infraspecificepithet { get; set; }

        public string scientificnameauthorship { get; set; }

        public string taxonomicstatus { get; set; }

        public string acceptednameusage { get; set; }

        public string higherclassification { get; set; }

        public string source { get; set; }

        public string references { get; set; }

        public string acceptednameusageid { get; set; }

        public string modified { get; set; }

        public List<NomeAceito> NOMEACEITO { get; set; }
    }

    public class NomeAceito
    {
        public string taxonid { get; set; }

        public string family { get; set; }

        public string genus { get; set; }

        public string scientificname { get; set; }

        public string specificepithet { get; set; }

        public object infraspecificepithet { get; set; }

        public string scientificnameauthorship { get; set; }

        public string taxonomicstatus { get; set; }

        public object acceptednameusage { get; set; }

        public string higherclassification { get; set; }

        public string source { get; set; }

        public string references { get; set; }
    }
}