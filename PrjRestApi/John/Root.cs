using System;
using System.Collections.Generic;
using System.Text;

namespace PrjRestApi.John
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Translations
    {
        public string de { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string it { get; set; }
        public string ja { get; set; }
        public string nl { get; set; }
        public string hr { get; set; }
    }

    public class Datum
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public List<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        public string numericCode { get; set; }
        public string alpha3Code { get; set; }
        public List<string> currencies { get; set; }
        public List<string> callingCodes { get; set; }
        public string capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string relevance { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public List<string> language { get; set; }
        public List<string> languages { get; set; }
        public Translations translations { get; set; }
        public int population { get; set; }
        public List<int> latlng { get; set; }
        public string demonym { get; set; }
        public List<string> borders { get; set; }
        public int area { get; set; }
        public double gini { get; set; }
        public List<string> timezones { get; set; }
    }

    public class Root
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public List<Datum> data { get; set; }
    }


}
