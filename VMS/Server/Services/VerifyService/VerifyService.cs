using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Server.Data;
using VMS.Shared;

namespace VMS.Server.Services.VerifyService
{
    public class VerifyService : IVerifyService
    {
        private readonly DataContext _data;

        public VerifyService(DataContext data)
        {
            _data = data;
        }

        List<Verify> Verifies = new List<Verify>();
        Verify verify = new Verify();

        public async Task<List<Verify>> AddVerify(Verify verify)
        {
            await _data.verify_info.AddAsync(verify);
            await _data.SaveChangesAsync();
            return Verifies = await _data.verify_info.ToListAsync();
        }

        public async Task<Verify> GetVerify(int verifyId)
        {
            return verify = await _data.verify_info.Where(v => v.Id == verifyId).FirstOrDefaultAsync();
        }

        public async Task<List<Verify>> LoadAllUVerifys()
        {
            return Verifies = await _data.verify_info.ToListAsync();
        }

        public async Task<List<Verify>> RemoveVerify(Verify verify)
        {
            _data.verify_info.Remove(verify);
            await _data.SaveChangesAsync();
            Verifies = await _data.verify_info.ToListAsync();
            return Verifies;
        }

        public async Task<List<Verify>> UpdateVerify(Verify verify)
        {
            Verifies = await _data.verify_info.ToListAsync();
            var dbVerify = await _data.verify_info.FindAsync(verify.Id);
            if (dbVerify != null)
            {
                _data.Entry(dbVerify).CurrentValues.SetValues(verify);
                await _data.SaveChangesAsync();
            }
            return Verifies;
        }
    }
}
