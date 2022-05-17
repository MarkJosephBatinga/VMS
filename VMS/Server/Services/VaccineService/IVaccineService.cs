using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Server.Services.VaccineService
{
    public interface IVaccineService
    {
        Task<List<Vaccine>> AddVaccine(Vaccine vaccine);
        Task<Vaccine> GetVaccine(int vaccineId);
        Task<List<Vaccine>> UpdateVaccine(Vaccine vaccine);
        Task<List<Vaccine>> RemoveVaccine(Vaccine vaccine);
        Task<List<Vaccine>> LoadAllVaccine();
    }
}
