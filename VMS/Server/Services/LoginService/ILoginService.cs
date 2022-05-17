using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Server.Services.LoginService
{
    public interface ILoginService
    {

        Task<User> LoginUser(LoginToken LoginUser);

        Task<User> GetUser(string email);

    }
}
