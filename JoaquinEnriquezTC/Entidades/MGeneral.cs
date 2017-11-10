using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    class MGeneral:Medico,IMedico
    {
        #region Constructores

        MGeneral(string nombre, string apellido)
            : base(nombre, apellido)
        { }
       
        #endregion 

        #region Méotodos de instancia publicos

        public void IniciarAtencion(Paciente p)
        {
            Thread miThread = new Thread(this.Atender);
            miThread.Start();
        }
        
        #endregion

        #region Métodos de instancia protegidos

        protected void Atender()
        {
            Thread.Sleep(tiempoAleatorio.Next(1500, 2200));
        }

        
        #endregion

    }
}
