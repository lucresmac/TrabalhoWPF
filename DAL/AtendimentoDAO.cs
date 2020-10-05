﻿using Hospital.Data;
using Hospital.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.DAL
{
    class AtendimentoDAO
    {
        private static Context context = new Context();

        public static bool CadastrarAtendimento(Atendimento atendimento)
        {
            try
            {
                context.Atendimentos.Add(atendimento);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<AtendimentoPaciente> BuscaAtendimento() /*=> context.Atendimentos.ToList();*/
        {
            var join = context.AtendimentoPacientes.FromSqlRaw("select a.tipo,a.Sintomas, p.* from atendimento a, pacientes p where a.id_paciente = p.ID");

            return join.ToList();
        }
    }
}
