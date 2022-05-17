using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly HttpClient _http;

        public LoginService(HttpClient http)
        {
            _http = http;
        }
        public async Task<User> GetUser(string email)
        {
            var result = await _http.GetFromJsonAsync<User>($"api/login/user/{email}");
            return result;
        }

        public async Task<User> LoginUser(LoginToken LoginUser)
        {
            var result = await _http.PostAsJsonAsync("api/login/user", LoginUser);
            var status = await result.Content.ReadFromJsonAsync<User>();
            return status;
        }
    }
}
