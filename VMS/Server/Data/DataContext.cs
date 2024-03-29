﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Shared;

namespace VMS.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> user_info { get; set; }
        public DbSet<Verify> verify_info { get; set; }
        public DbSet<Admin> admin_info { get; set; }
        public DbSet<Vaccine> vaccine_info { get; set; }
        public DbSet<Appoint> appointment_info { get; set; }
    }
}
