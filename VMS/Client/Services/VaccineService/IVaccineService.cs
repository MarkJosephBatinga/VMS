using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.VaccineService
{
    interface IVaccineService
    {
        Task<List<Vaccine>> AddVaccine(Vaccine vaccine);

        Task<List<Vaccine>> UpdateVaccine(Vaccine vaccine);

        Task<List<Vaccine>> DeleteVaccine(Vaccine vaccine);

        Task<List<Vaccine>> GetAllVaccine();

        Task<Vaccine> GetVaccine(int Id);
    }
}
