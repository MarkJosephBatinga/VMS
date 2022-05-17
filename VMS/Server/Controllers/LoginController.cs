using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Server.Services.LoginService;
using VMS.Shared;

namespace VMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        User user = new User();

        [HttpPost("user")]
        public async Task<ActionResult<User>> LoginAsUser(LoginToken LoginUser)
        {
            return user = await _service.LoginUser(LoginUser);
        }

        [HttpGet("user/{email}")]
        public async Task<ActionResult<User>> GetUser(string email)
        {
            return user = await _service.GetUser(email);
        }
    }
}
