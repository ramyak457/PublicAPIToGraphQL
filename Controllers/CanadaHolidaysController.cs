using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using VaccinationAPI.ViewModels.Holidays;

namespace VaccinationAPI.Controllers
{
    [Route("api/v1/holidays")]
    [ApiController]
    public class CanadaHolidaysController : Controller
    {
        private CanadaHolidaysRepository _holidayRepository;
        public CanadaHolidaysController(CanadaHolidaysRepository holidayRepository)
        {
            _holidayRepository = holidayRepository;
        }

        [HttpGet("{holidayId:int:min(1):max(32)}")]
        public async Task<CanadaHolidays> GetHolidayById([FromRoute] int holidayId, [FromQuery][Range(2015, 2031)] string year, [FromQuery] string optional)
        {
            return await _holidayRepository.GetHolidayById(holidayId, year, optional);
        }

        [HttpGet]
        public async Task<CanadaHolidaysList> GetHoliday([FromQuery][Range(2015,2031)] string year, [FromQuery] string federal, [FromQuery] string optional)
        {
            return await _holidayRepository.GetHoliday(year,federal,optional);
        }

    }
}
