using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio031
{
    class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Numero
        {
            get { return this.numero; }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre)
        {
            this.nombre = nombre;
            this.numero = numero;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool returnAux = false;

            if (c1.Numero == c2.Numero)
                returnAux = true;

            return returnAux;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            bool returnAux = false;
            if (c1.Numero != c2.Numero)
                returnAux = true;

            return returnAux;
        }


    }
}
