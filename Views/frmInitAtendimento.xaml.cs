using Hospital.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hospital.Views
{
    /// <summary>
    /// Lógica interna para frmInitAtendimento.xaml
    /// </summary>
    public partial class frmInitAtendimento : Window
    {
        public int id;
        public frmInitAtendimento(int ID)
        {
            InitializeComponent();
            id = ID;
            var paciente = PacienteDAO.BuscaPacienteID(ID);
            txtNome.Text = paciente.Nome;
        }
    }
}
