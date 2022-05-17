using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.AdminService
{
    interface IAdminService
    {
        Task<List<Admin>> AddAdmin(Admin admin);

        Task<List<Admin>> UpdateAdmin(Admin admin);

        Task<List<Admin>> DeleteAdmin(Admin admin);

        Task<List<Admin>> GetAllAdmin();

        Task<Admin> GetAdmin(int Id);
    }
}
