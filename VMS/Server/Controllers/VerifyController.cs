using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Server.Services.VerifyService;
using VMS.Shared;

namespace VMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerifyController : ControllerBase
    {
        private readonly IVerifyService _service;

        public VerifyController(IVerifyService service)
        {
            _service = service;
        }

        List<Verify> Verifies = new List<Verify>();
        Verify verify = new Verify();

        [HttpPost("create")]
        public async Task<ActionResult<List<Verify>>> AddVerify(Verify verify)
        {
            return Verifies = await _service.AddVerify(verify);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Verify>>> UpdateVerify(Verify verify)
        {
            return Verifies = await _service.UpdateVerify(verify);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Verify>>> DeleteVerify(Verify verify)
        {
            return Verifies = await _service.RemoveVerify(verify);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Verify>>> GetAllVerify()
        {
            return Verifies = await _service.LoadAllUVerifys();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Verify>> GetVerify(int Id)
        {
            return verify = await _service.GetVerify(Id);
        }
    }
}
