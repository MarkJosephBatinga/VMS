using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.VerifyService
{
    interface IVerifyService
    {
        Task<List<Verify>> AddVerify(Verify verify);

        Task<List<Verify>> UpdateVerify(Verify verify);

        Task<List<Verify>> DeleteVerify(Verify verify);

        Task<List<Verify>> GetAllVerify();

        Task<Verify> GetVerify(int Id);
    }
}
