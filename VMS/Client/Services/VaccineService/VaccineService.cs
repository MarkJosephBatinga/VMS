using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.VaccineService
{
    public class VaccineService : IVaccineService
    {
        private readonly HttpClient _http;

        public VaccineService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Vaccine>> AddVaccine(Vaccine vaccine)
        {
            var result = await _http.PostAsJsonAsync("api/vaccine/create", vaccine);
            var status = await result.Content.ReadFromJsonAsync<List<Vaccine>>();
            return status;
        }

        public async Task<List<Vaccine>> DeleteVaccine(Vaccine vaccine)
        {
            var result = await _http.PostAsJsonAsync("api/vaccine/delete", vaccine);
            var status = await result.Content.ReadFromJsonAsync<List<Vaccine>>();
            return status;
        }

        public async Task<List<Vaccine>> GetAllVaccine()
        {
            var result = await _http.GetFromJsonAsync<List<Vaccine>>($"api/vaccine/displayall");
            return result;
        }

        public async Task<Vaccine> GetVaccine(int Id)
        {
            var result = await _http.GetFromJsonAsync<Vaccine>($"api/vaccine/display/{Id}");
            return result;
        }

        public async Task<Vaccine> GetVaccinePerUser(int Id)
        {
            var result = await _http.GetFromJsonAsync<Vaccine>($"api/vaccine/displayperuser/{Id}");
            return result;
        }

        public async Task<List<Vaccine>> UpdateVaccine(Vaccine vaccine)
        {
            var result = await _http.PostAsJsonAsync("api/vaccine/update", vaccine);
            var status = await result.Content.ReadFromJsonAsync<List<Vaccine>>();
            return status;
        }
    }
}
