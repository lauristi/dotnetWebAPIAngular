namespace webapi.Business.Models.BrazilianFloraAPI
{
    public class SpeciesResponse
    {
        public bool success { get; set; }

        public List<SpeciesResult> result { get; set; }
    }

    public class SpeciesResult
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
    }
}