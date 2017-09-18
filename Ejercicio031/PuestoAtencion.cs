using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio031
{
    class PuestoAtencion
    {
        enum Puesto { Caja1, Caja2 }

        static private int numeroActual;
        private Puesto puesto;
       
        public PuestoAtencion(Puesto puesto)
        {
            numeroActual = 0;
        }


        private static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            } 
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(cli.Numero);
            return true;
        }



    }
}
