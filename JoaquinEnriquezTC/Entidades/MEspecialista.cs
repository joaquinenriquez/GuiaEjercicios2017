using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class MEspecialista:Medico, IMedico
    {
        #region Enumerados

        enum Especialidad { Traumatologo, Odontologo };
        
        #endregion

        #region Atributos

        Especialidad especialidad;
    
        #endregion

        #region Méotodos protegidos

        protected void Atender
        { 
       
        }
        
        #endregion

        #region Méotodos de Instancia

        public void IniciarAtencion(Paciente p)
        { }

        #endregion

        #region Constructores

        public MEspecialista(string nombre, string apellido, Especialidad e):base(nombre, apellido
        {
            this.especialidad = e;
        }
       
        #endregion
    }
}
