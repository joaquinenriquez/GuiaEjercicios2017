using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    static class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool returnAux = false;

            if (char.ToLower(c) == 's')
                returnAux = true;

            return returnAux;
        }


    }
}
