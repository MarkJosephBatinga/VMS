using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Server.Data;
using VMS.Shared;

namespace VMS.Server.Services.AppointService
{
    public class AppointService : IAppointService
    {
        private readonly DataContext _data;

        public AppointService(DataContext data)
        {
            _data = data;
        }

        List<Appoint> Appoints = new List<Appoint>();
        Appoint appoint = new Appoint();

        public async Task<List<Appoint>> AddAppoint(Appoint appoint)
        {
            await _data.appointment_info.AddAsync(appoint);
            await _data.SaveChangesAsync();
            return Appoints = await _data.appointment_info.ToListAsync();
        }

        public async Task<Appoint> GetAppoint(int appointId)
        {
            return appoint = await _data.appointment_info.Where(a => a.Id == appointId).FirstOrDefaultAsync();
        }

        public async Task<List<Appoint>> LoadAllAppoints()
        {
            return Appoints = await _data.appointment_info.ToListAsync();
        }

        public async Task<List<Appoint>> RemoveAppoint(Appoint appoint)
        {
            _data.appointment_info.Remove(appoint);
            await _data.SaveChangesAsync();
            Appoints = await _data.appointment_info.ToListAsync();
            return Appoints;
        }

        public async Task<List<Appoint>> UpdateAppoint(Appoint appoint)
        {
            Appoints = await _data.appointment_info.ToListAsync();
            var dbAppoint = await _data.appointment_info.FindAsync(appoint.Id);
            if (dbAppoint != null)
            {
                _data.Entry(dbAppoint).CurrentValues.SetValues(appoint);
                await _data.SaveChangesAsync();
            }
            return Appoints;
        }
    }
}
