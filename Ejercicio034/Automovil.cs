using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio034
{
    enum Colores { Rojo, Blanco, Azul, Gris, Negro };

    class Automovil:VehiculoTerrestre
    {
        #region Atributos
        //private short cantidadRuedas;
        private int cantidadPasajeros;
        private short cantidadPuertas;
        private short cantidadMarchas;
        //private Colores color;


        #endregion

        #region Constructores
        private Automovil(short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        #endregion

    }
}
