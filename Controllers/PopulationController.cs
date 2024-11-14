using Microsoft.AspNetCore.Mvc;
using VaccinationAPI.ViewModels.Population;

namespace VaccinationAPI.Controllers
{
    [ApiController]
    public class PopulationController
    {
        private PopulationRepository _populationRepository;
        public PopulationController(PopulationRepository populationRepository) { 
            _populationRepository = populationRepository;
        }
       
        [Route("api/pop")]
        [HttpGet]
        public async Task<List<PopulationInfo>> GetPopulation()
        {           
            return await _populationRepository.GetPopulation();
        }
        [Route("api/pop/{stateName}")]
        [HttpGet]
        public async Task<PopulationObject> GetPopulationByState(string stateName)
        {
            using(var client = new HttpClient())
            {
                return await _populationRepository.GetPopulationByState(stateName);
            }
        }

    }
}
