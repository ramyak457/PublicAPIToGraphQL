using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VaccinationAPI.ViewModels.Holidays;
using VaccinationAPI.ViewModels.Population;
using VaccinationAPI.ViewModels.Provinces;

namespace VaccinationAPI.Controllers
{
    [Route("api/v1/provinces")]
    [ApiController]
    public class ProvinceController
    {
        private ProvinceRepository _provinceRepository;
        public ProvinceController(ProvinceRepository provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }

       
        [HttpGet("{provinceId}")]
        public async Task<CanadaProvinces> GetProvinceById([FromRoute] string provinceId, [FromQuery] [Range(2015,2031)] string year, [FromQuery] string optional)
        {
            return await _provinceRepository.GetProvinceById(provinceId, year, optional);
        }

        [HttpGet]
        public async Task<CanadaProvincesList> GetAllProvinces([FromQuery][Range(2015, 2031)] string year, [FromQuery] string optional)
        {
            return await _provinceRepository.GetAllProvinces(year, optional);
        }


    }
}
