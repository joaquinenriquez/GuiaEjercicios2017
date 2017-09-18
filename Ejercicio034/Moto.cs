using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio034
{
    class Moto:VehiculoTerrestre
    {
        #region Atributos
        
        //private Colores color;
        private short cilindrada;
        #endregion

        #region Constructores
        
        private Moto(short cilindrada, Colores color)
        {
            this.cilindrada = cilindrada;
            this.color = color;
        }
        
        #endregion

    }
}
