using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Server.Services.VerifyService
{
    public interface IVerifyService
    {
        Task<List<Verify>> AddVerify(Verify verify);

        Task<Verify> GetVerify(int verifyId);

        Task<List<Verify>> UpdateVerify(Verify verify);

        Task<List<Verify>> RemoveVerify(Verify verify);

        Task<List<Verify>> LoadAllUVerifys();
    }
}
