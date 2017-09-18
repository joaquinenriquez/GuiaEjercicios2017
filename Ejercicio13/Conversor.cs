using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    static class Conversor
    {
        public static string DecimalBinario (double nroDecimal)
        {
            StringBuilder nroBinario = new StringBuilder();
           
            while(nroDecimal > 1)
            {
                //Insertamos adelante de todo (no usamos append porque lo agrega siempre atras)
                nroBinario.Insert(0, (int) nroDecimal % 2);
                nroDecimal = nroDecimal / 2;
            }

            return nroBinario.ToString();
        }

        public static double BinarioDecimal(string nroBinario)
        {
            double nroDecimal = 0;
            byte potencia = 0;

            for (int cifra = nroBinario.Length - 1; cifra > 0; cifra--)
            {

                if (nroBinario[cifra] == '1')
                    nroDecimal += Math.Pow(2, potencia);
        
                potencia++;
            }

            return nroDecimal;
        }

        public static bool ValidarBinario(string nroBinario)
        {
            bool auxReturn = true;

            foreach(char cifra in nroBinario)
            {
                if ((cifra != '0') || (cifra != '1'))
                {
                    auxReturn = false;
                    break;
                }
            }

            return auxReturn;
        }

    }
}
