using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.VerifyService
{
    public class VerifyService : IVerifyService
    {
        private readonly HttpClient _http;

        public VerifyService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Verify>> AddVerify(Verify verify)
        {
            var result = await _http.PostAsJsonAsync("api/verify/create", verify);
            var status = await result.Content.ReadFromJsonAsync<List<Verify>>();
            return status;
        }

        public async Task<List<Verify>> DeleteVerify(Verify verify)
        {
            var result = await _http.PostAsJsonAsync("api/verify/delete", verify);
            var status = await result.Content.ReadFromJsonAsync<List<Verify>>();
            return status;
        }

        public async Task<List<Verify>> GetAllVerify()
        {
            var result = await _http.GetFromJsonAsync<List<Verify>>($"api/verify/displayall");
            return result;
        }

        public async Task<Verify> GetVerify(int Id)
        {
            var result = await _http.GetFromJsonAsync<Verify>($"api/verify/display/{Id}");
            return result;
        }

        public async Task<List<Verify>> UpdateVerify(Verify verify)
        {

            var result = await _http.PostAsJsonAsync("api/verify/update", verify);
            var status = await result.Content.ReadFromJsonAsync<List<Verify>>();
            return status;
        }
    }
}
