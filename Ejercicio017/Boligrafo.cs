using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio017
{
    class Boligrafo
    {
        #region Atributos
        const short CANTIDAD_TINTA_MAXIMA = 100;
        private ConsoleColor color;
        private int tinta;

        #endregion


        #region Métodos Públicos

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public int GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            if 

        }

        public void Recargar()
        {
            this.SetTinta(CANTIDAD_TINTA_MAXIMA);
        }

        #endregion

        #region Métodos Privados

        private void SetTinta(short tinta)
        {
            if ((tinta >= 0) && tinta <= CANTIDAD_TINTA_MAXIMA)
                this.tinta = tinta;
        }


        #endregion
    }
}
