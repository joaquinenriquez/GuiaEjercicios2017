using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio034
{
    abstract class VehiculoTerrestre
    {
        protected short cantidadRuedas;
        protected Colores color;

        VehiculoTerrestre(short cantidadRuedas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
        }
    }
}
