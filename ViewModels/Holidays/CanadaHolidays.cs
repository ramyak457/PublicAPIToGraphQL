using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels.Holidays
{
    public class CanadaHolidays
    {

        [JsonPropertyName("holiday")]
        public HolidayInfo Holiday { get; set; }
    }
}
