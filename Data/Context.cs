using Hospital.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Data
{
    class Context : DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Hospital;Trusted_Connection=true");
        }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
