using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels.Holidays
{
    public class CanadaHolidaysList
    {
        [JsonPropertyName("holidays")]
        public List<HolidayInfo> Holiday { get; set; }
    }
}
