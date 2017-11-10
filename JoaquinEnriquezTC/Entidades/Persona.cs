using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Persona
    {
        #region Atributos

        protected string apellido;
        protected string nombre;

        #endregion

        #region Constructores
        
        public Persona(String nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        #endregion
    }
}
