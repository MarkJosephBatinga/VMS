using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Server.Data;
using VMS.Shared;

namespace VMS.Server.Services.VaccineService
{
    public class VaccineService : IVaccineService
    {
        private readonly DataContext _data;

        public VaccineService(DataContext data)
        {
            _data = data;
        }

        List<Vaccine> Vaccines = new List<Vaccine>();
        Vaccine vaccine = new Vaccine();

        public async Task<List<Vaccine>> AddVaccine(Vaccine vaccine)
        {
            var result = await _data.verify_info.Where(v => v.UserId == vaccine.UserId).FirstOrDefaultAsync();
            _data.verify_info.Remove(result);
            await _data.vaccine_info.AddAsync(vaccine);
            await _data.SaveChangesAsync();
            return Vaccines = await _data.vaccine_info.ToListAsync();
        }

        public async Task<Vaccine> GetVaccine(int vaccineId)
        {
            return vaccine = await _data.vaccine_info.Where(v => v.Id == vaccineId).FirstOrDefaultAsync();
        }

        public async Task<List<Vaccine>> LoadAllVaccine()
        {
            return Vaccines = await _data.vaccine_info.ToListAsync();
        }

        public async Task<List<Vaccine>> RemoveVaccine(Vaccine vaccine)
        {
            _data.vaccine_info.Remove(vaccine);
            await _data.SaveChangesAsync();
            Vaccines = await _data.vaccine_info.ToListAsync();
            return Vaccines;
        }

        public async Task<List<Vaccine>> UpdateVaccine(Vaccine vaccine)
        {
            Vaccines = await _data.vaccine_info.ToListAsync();
            var dbVaccine = await _data.vaccine_info.FindAsync(vaccine.Id);
            if (dbVaccine != null)
            {
                _data.Entry(dbVaccine).CurrentValues.SetValues(vaccine);
                await _data.SaveChangesAsync();
            }
            return Vaccines;
        }

        public async Task<Vaccine> GetVaccinePerUser(int userId)
        {
            vaccine = await _data.vaccine_info.Where(v => v.UserId == userId).FirstOrDefaultAsync();
            if (vaccine == null)
            {
                return vaccine = new Vaccine();
            }
            else
            {
                return vaccine;
            }
        }
    }
}
