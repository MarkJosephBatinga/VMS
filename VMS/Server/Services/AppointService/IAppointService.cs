using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Server.Services.AppointService
{
    public interface IAppointService
    {
        Task<List<Appoint>> AddAppoint(Appoint appoint);

        Task<Appoint> GetAppoint(int appointId);

        Task<List<Appoint>> UpdateAppoint(Appoint appoint);

        Task<List<Appoint>> RemoveAppoint(Appoint appoint);

        Task<List<Appoint>> LoadAllAppoints();
    }
}
