using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio010
{
    static class Validacion
    {
        public static bool Validar(int valor, int max, int min)
        {
            bool returnAux = false;

            if ((valor <= max) && (valor >= min))
                returnAux = true;

            return returnAux;
        }

    }
}
