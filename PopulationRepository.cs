using System;
using VaccinationAPI.ViewModels.Population;

namespace VaccinationAPI
{
    public class PopulationRepository
    {
        private readonly string url = "https://myvaccination-backend.vercel.app/api/pop";

        public async Task<List<PopulationInfo>> GetPopulation()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var populationList = await response.Content.ReadFromJsonAsync<List<PopulationInfo>>();
                return populationList;
            }
        }

        public async Task<PopulationObject> GetPopulationByState(string stateName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url + "/" + stateName);
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var populationByState = await response.Content.ReadFromJsonAsync<PopulationObject>();
                return populationByState;
            }
        }
    }
}
