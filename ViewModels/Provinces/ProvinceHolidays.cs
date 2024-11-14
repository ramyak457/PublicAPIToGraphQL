using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels.Provinces
{
    public class ProvinceHolidays
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }
        [JsonPropertyName("date")]
        public string Date { get; set; }
        [JsonPropertyName("nameEn")]
        public string NameEn { get; set; }
        [JsonPropertyName("nameFr")]
        public string NameFr { get; set; }
        [JsonPropertyName("federal")]
        public int Federal { get; set; }
        [JsonPropertyName("observedDate")]
        public string ObservedDate { get; set; }
    }
}
