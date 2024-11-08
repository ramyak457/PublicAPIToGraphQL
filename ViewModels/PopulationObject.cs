using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels
{
    public class PopulationObject
    {
        [JsonPropertyName("modifiedData")]
        public Population Population { get; set; }
    }
}
