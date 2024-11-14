using System.Text.Json.Serialization;
using VaccinationAPI.ViewModels.Holidays;

namespace VaccinationAPI.ViewModels.Provinces
{
    public class CanadaProvinces
    {
        [JsonPropertyName("province")]
        public ProvinceData Province { get; set; }
    }
}
