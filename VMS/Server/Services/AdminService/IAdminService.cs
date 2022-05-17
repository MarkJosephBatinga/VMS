using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Server.Services.AdminService
{
    public interface IAdminService
    {
        Task<List<Admin>> AddAdmin(Admin admin);

        Task<Admin> GetAdmin(int adminId);

        Task<List<Admin>> UpdateAdmin(Admin admin);

        Task<List<Admin>> RemoveAdmin(Admin admin);

        Task<List<Admin>> LoadAllAdmins();
    }
}
