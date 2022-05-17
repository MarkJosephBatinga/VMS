using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Server.Services.VaccineService;
using VMS.Shared;

namespace VMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        private readonly IVaccineService _service;

        public VaccineController(IVaccineService service)
        {
            _service = service;
        }

        List<Vaccine> Vaccines = new List<Vaccine>();
        Vaccine vaccine = new Vaccine();

        [HttpPost("create")]
        public async Task<ActionResult<List<Vaccine>>> AddVaccine(Vaccine vaccine)
        {
            return Vaccines = await _service.AddVaccine(vaccine);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Vaccine>>> UpdateVaccine(Vaccine vaccine)
        {
            return Vaccines = await _service.UpdateVaccine(vaccine);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Vaccine>>> DeleteVaccine(Vaccine vaccine)
        {
            return Vaccines = await _service.RemoveVaccine(vaccine);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Vaccine>>> GetAllVaccine()
        {
            return Vaccines = await _service.LoadAllVaccine();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Vaccine>> GetVaccine(int Id)
        {
            return vaccine = await _service.GetVaccine(Id);
        }
    }
}
