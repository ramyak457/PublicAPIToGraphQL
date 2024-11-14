using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels.Population
{
    public class PopulationInfo
    {
        [JsonPropertyName("stateName")]
        public string StateName { get; set; }

        [JsonPropertyName("total")]
        public long Total { get; set; }
        [JsonPropertyName("18to59")]
        public long YoungGroup { get; set; }
        [JsonPropertyName("60AndAbove")]
        public long SeniorGroup { get; set; }
    }
}
