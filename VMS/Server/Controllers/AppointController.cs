using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Server.Services.AppointService;
using VMS.Shared;

namespace VMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointController : ControllerBase
    {
        private readonly IAppointService _service;

        public AppointController(IAppointService service)
        {
            _service = service;
        }

        List<Appoint> Appoints = new List<Appoint>();
        Appoint appoint = new Appoint();

        [HttpPost("create")]
        public async Task<ActionResult<List<Appoint>>> AddVerify(Appoint appoint)
        {
            return Appoints = await _service.AddAppoint(appoint);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Appoint>>> UpdateVerify(Appoint appoint)
        {
            return Appoints = await _service.UpdateAppoint(appoint);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Appoint>>> DeleteVerify(Appoint appoint)
        {
            return Appoints = await _service.RemoveAppoint(appoint);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Appoint>>> GetAllVerify()
        {
            return Appoints = await _service.LoadAllAppoints();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Appoint>> GetVerify(int Id)
        {
            return appoint = await _service.GetAppoint(Id);
        }
    }
}
