using System.Security.Cryptography.X509Certificates;

using Microsoft.AspNetCore.WebUtilities;
using VaccinationAPI.ViewModels.Holidays;

namespace VaccinationAPI
{
    public class CanadaHolidaysRepository
    {
        private readonly string url = "https://canada-holidays.ca/api/v1/holidays";

        public async Task<CanadaHolidays> GetHolidayById(int holidayId, string year, string optional)
        {
            using (var client = new HttpClient())
            {
                var baseAddress = String.Concat(url + "/" + holidayId);

                var query = new Dictionary<string, string>
                {
                    { "year", year },
                    { "optional", optional}
                };

                client.BaseAddress = new Uri(QueryHelpers.AddQueryString(baseAddress, query));
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var holidaysList = await response.Content.ReadFromJsonAsync<CanadaHolidays>();
                return holidaysList;
            }
        }
        public async Task<CanadaHolidaysList> GetHoliday(string year, string federal, string optional)
        {
            using (var client = new HttpClient())
            {
                var query = new Dictionary<string, string>
                {
                    { "year", year },
                    { "federal", federal },
                    { "optional", optional}
                };

                client.BaseAddress = new Uri(QueryHelpers.AddQueryString(url, query));
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var holidaysList = await response.Content.ReadFromJsonAsync<CanadaHolidaysList>();
                return holidaysList;
            }
        }
    }
}
