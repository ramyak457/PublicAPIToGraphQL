using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels.Provinces
{
    public class CanadaProvincesList
    {
        [JsonPropertyName("provinces")]
        public List<ProvinceData> Provinces { get; set; }
    }
}
