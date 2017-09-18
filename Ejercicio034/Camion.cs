using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio034
{
    class Camion:VehiculoTerrestre
    {
        #region Atributos

        //private short cantidadRuedas;
        private short cantidadPuertas;
        //private Colores color;
        private short cantidadMarchas;
        private int pesoCarga;

        #endregion

        #region Constructores
        
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
        
        #endregion

    }
}
