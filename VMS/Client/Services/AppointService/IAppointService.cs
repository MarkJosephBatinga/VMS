using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.AppointService
{
    interface IAppointService
    {
        Task<List<Appoint>> AddAppoint(Appoint appoint);

        Task<List<Appoint>> UpdateAppoint(Appoint appoint);

        Task<List<Appoint>> DeleteAppoint(Appoint appoint);

        Task<List<Appoint>> GetAllAppoint();

        Task<Appoint> GetAppoint(int Id);
    }
}
