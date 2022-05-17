using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.CovidService
{
    interface ICovidService
    {
        Task<Covid> GetCovidAnalytics(); 
    }
}
