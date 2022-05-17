using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.LoginService
{
    interface ILoginService
    {
        Task<User> GetUser(string email);

        Task<User> LoginUser(LoginToken LoginUser);
    }
}
