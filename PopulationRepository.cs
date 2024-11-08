using System;
using VaccinationAPI.ViewModels;

namespace VaccinationAPI
{
    public class PopulationRepository
    {
        string url = "https://myvaccination-backend.vercel.app/";
        public async Task<List<Population>> GetPopulation()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url + "api/pop");
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var populationList = await response.Content.ReadFromJsonAsync<List<Population>>();
                return populationList;
            }
        }
    }
}
