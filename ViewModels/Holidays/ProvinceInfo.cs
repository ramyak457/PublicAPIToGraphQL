using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels.Holidays
{
    public class ProvinceInfo
    {
        [JsonPropertyName("id")]
        public string ID { get; set; }
        [JsonPropertyName("nameEn")]
        public string NameEn { get; set; }
        [JsonPropertyName("nameFr")]
        public string NameFr { get; set; }
        [JsonPropertyName("sourceLink")]
        public string SourceLink { get; set; }
        [JsonPropertyName("sourceEn")]
        public string SourceEn { get; set; }
    }
}
