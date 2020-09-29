using Hospital.Data;
using Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Hospital.DAL
{
    class PacienteDAO
    {
        private static Context context = new Context();

        public static Paciente BuscaPacienteID(int atendimento) => context.Pacientes.FirstOrDefault(x => x.ID == atendimento);
        public static Paciente BuscaPacienteNome(string nome) => context.Pacientes.FirstOrDefault(x => x.Nome == nome);

        public static bool CadastrarPaciente(Paciente paciente)
        {
            if(BuscaPacienteNome(paciente.Nome) == null)
            {
                context.Pacientes.Add(paciente);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
