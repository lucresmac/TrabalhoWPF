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
            options.UseSqlServer(@"Server=tcp:servidorfacu.database.windows.net,1433;Initial Catalog=Hospital_Medico;Persist Security Info=False;User ID=lucresmac;Password=teste22!@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
