using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    abstract class Medico:Persona
    {
        #region Atributos

        public delegate void delegado1(object sender, EventArgs e);
        public event delegado1 FinDeAtencionPaciente;

        Paciente pacienteActual;
        protected static Random tiempoAleatorio;

        #endregion

        #region Propiedades

        public Paciente AtenderA
        {
            set { this.pacienteActual = value; }
        }

        public virtual Paciente EstaAtendiendoA
        {
            get { return this.pacienteActual; }
        }
        
        #endregion

        #region Constructores

        static Medico()
        {
            tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido):base(nombre, apellido)
        { 
        
        }

        
        #endregion

        #region Métodos protegidos

        protected abstract void Atender();


        protected void FinalizarAtencion()
        {
            this.FinDeAtencionPaciente(this, new EventArgs());
            this.pacienteActual = null;
        }
        
        #endregion


    }
}
