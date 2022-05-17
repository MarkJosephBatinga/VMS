﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Client.Services.UserService
{
    interface IUserService
    {
        Task<List<User>> AddUser(User user);

        Task<List<User>> UpdateUser(User user);

        Task<List<User>> DeleteUser(User user);

        Task<List<User>> GetAllUser();
        Task<List<User>> GetAllUnvaccinatedUser();

        Task<User> GetUser(int Id);
    }
}
