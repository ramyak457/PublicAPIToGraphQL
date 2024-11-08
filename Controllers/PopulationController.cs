using Microsoft.AspNetCore.Mvc;
using VaccinationAPI.Services;
using VaccinationAPI.ViewModels;

namespace VaccinationAPI.Controllers
{
    [ApiController]
    public class PopulationController
    {
        private PopulationRepository _populationRepository;
        string url = "https://myvaccination-backend.vercel.app/";
        public PopulationController(PopulationRepository populationRepository) { 
            _populationRepository = populationRepository;
        }
       
        [Route("api/pop")]
        [HttpGet]
        public async Task<List<Population>> GetPopulation()
        {
            //PopulationRepository populationRepository = new PopulationRepository();
           
            return await _populationRepository.GetPopulation();
        }
        [Route("api/pop/{stateName}")]
        [HttpGet]
        public async Task<PopulationObject> GetPopulationByState(string stateName)
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url + "api/pop/"+stateName);
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var populationByState = await response.Content.ReadFromJsonAsync<PopulationObject>();
                return populationByState;
            }
        }

    }
}
