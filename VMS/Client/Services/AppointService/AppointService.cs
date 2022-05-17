using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.AppointService
{
    public class AppointService : IAppointService
    {
        private readonly HttpClient _http;

        public AppointService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Appoint>> AddAppoint(Appoint appoint)
        {
            var result = await _http.PostAsJsonAsync("api/appoint/create", appoint);
            var status = await result.Content.ReadFromJsonAsync<List<Appoint>>();
            return status;
        }

        public async Task<List<Appoint>> DeleteAppoint(Appoint appoint)
        {
            var result = await _http.PostAsJsonAsync("api/appoint/delete", appoint);
            var status = await result.Content.ReadFromJsonAsync<List<Appoint>>();
            return status;
        }

        public async Task<List<Appoint>> GetAllAppoint()
        {
            var result = await _http.GetFromJsonAsync<List<Appoint>>($"api/appoint/displayall");
            return result;
        }

        public async Task<Appoint> GetAppoint(int Id)
        {
            var result = await _http.GetFromJsonAsync<Appoint>($"api/appoint/display/{Id}");
            return result;
        }

        public async Task<List<Appoint>> UpdateAppoint(Appoint appoint)
        {
            var result = await _http.PostAsJsonAsync("api/appoint/update", appoint);
            var status = await result.Content.ReadFromJsonAsync<List<Appoint>>();
            return status;
        }
    }
}
