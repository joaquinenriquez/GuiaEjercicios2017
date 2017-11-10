using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Paciente:Persona
    {
        #region Atributos

        int turno;
        static int ultimoTurnoDado;

        #endregion

        #region Constructores

        static Paciente()
        {
            Paciente.ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido):base(nombre, apellido)
        {
            Paciente.ultimoTurnoDado++;
            this.turno = ultimoTurnoDado;
        }

        public Paciente(string nombre, string apellido, int turno):this(nombre, apellido)
        {
            Paciente.ultimoTurnoDado = turno;
            this.turno = turno;
        }

        #endregion

        #region Sobreescritura de métodos

        public override string ToString()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendFormat("Turno Nº{0}; {2}, {1}", this.turno, this.apellido, this.nombre);

            return salida.ToString();
        }
        
        #endregion
    }
}
