using System;
using VaccinationAPI.ViewModels;

namespace VaccinationAPI
{
    public class PopulationRepository
    {
        private readonly string url = "https://myvaccination-backend.vercel.app/api/pop";

        public async Task<List<Population>> GetPopulation()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var populationList = await response.Content.ReadFromJsonAsync<List<Population>>();
                return populationList;
            }
        }

        public async Task<PopulationObject> GetPopulationByState(string stateName)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url + stateName);
                response.EnsureSuccessStatusCode();
                var populationByState = await response.Content.ReadFromJsonAsync<PopulationObject>();
                return populationByState;
            }
        }
    }
}
