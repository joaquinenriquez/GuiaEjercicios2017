using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio031
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> Clientes = new Queue<Cliente>();
        private string nombre;

        private Negocio()
        {

        }


        public Cliente Cliente
        {
            get { return this.Clientes.ElementAt(0); }
            set
            {
                if (!Clientes.Contains(value))
                    Clientes.Enqueue(value);
            }
        }

       
    }
}
