using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.CovidService
{
    public class CovidService : ICovidService
    {
        private readonly HttpClient _http;

        public CovidService(HttpClient http)
        {
            _http = http;
        }
        public async Task<Covid> GetCovidAnalytics()
        {
            var result = await _http.GetFromJsonAsync<Covid>("https://covid19-api-philippines.herokuapp.com/api/summary");
            return result;
        }
    }
}
