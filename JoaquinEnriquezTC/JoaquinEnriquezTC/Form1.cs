using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace JoaquinEnriquezTC
{
    public partial class frmFinal : Form
    {
        #region Atributos

        MEspecialista medicoEspecialista;
        MGeneral medicoGeneral;
        Thread mocker;
        Queue<Paciente> pacientesEnEspera;

        #endregion

        #region Métodos de instancia
    
        private void AtenderPaciente(IMedico iMedico)
        {
        
        }
        
        #endregion

        #region Constructor

        public frmFinal()
        {
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias");
        }
        
        #endregion


        public frmFinal()
        {
            InitializeComponent();
        }
    }
}
