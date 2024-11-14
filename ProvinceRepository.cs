using Microsoft.AspNetCore.WebUtilities;
using VaccinationAPI.ViewModels.Holidays;
using VaccinationAPI.ViewModels.Provinces;

namespace VaccinationAPI
{
    public class ProvinceRepository
    {
        private readonly string url = "https://canada-holidays.ca/api/v1/provinces";
        public async Task<CanadaProvinces> GetProvinceById(string provinceId, string year, string optional)
        {
            using (var client = new HttpClient())
            {
                var baseAddress = String.Concat(url + "/" + provinceId);

                var query = new Dictionary<string, string>
                {
                    { "year", year },
                    { "optional", optional}
                };

                client.BaseAddress = new Uri(QueryHelpers.AddQueryString(baseAddress, query));
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var provinceHolidaysList = await response.Content.ReadFromJsonAsync<CanadaProvinces>();
                return provinceHolidaysList;
            }
        }

        public async Task<CanadaProvincesList> GetAllProvinces(string year, string optional)
        {
            using (var client = new HttpClient())
            {
                var query = new Dictionary<string, string>
                {
                    { "year", year },
                    { "optional", optional}
                };

                client.BaseAddress = new Uri(QueryHelpers.AddQueryString(url, query));
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();
                var provinceList = await response.Content.ReadFromJsonAsync<CanadaProvincesList>();
                return provinceList;
            }
        }
    }

}
