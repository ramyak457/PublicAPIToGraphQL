using System.Text.Json.Serialization;

namespace VaccinationAPI.ViewModels.Population
{
    public class PopulationObject
    {
        [JsonPropertyName("modifiedData")]
        public PopulationInfo ModifiedData { get; set; }
    }
}
