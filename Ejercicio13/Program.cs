using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de decimal a binario.
double BinarioDecimal(string). Convierte un número binario a decimal.
*/

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            const double NRO_DECIMAL = 254;
            const string NRO_BINARIO = "‭11111111";

            Console.WriteLine("BINARIO A DECIMAL ({0}): {1}", NRO_BINARIO, Conversor.BinarioDecimal(NRO_BINARIO));
            Console.WriteLine("DECIMAL A BINARIO ({0}): {1}", NRO_DECIMAL, Conversor.DecimalBinario(NRO_DECIMAL));

        }
    }
}
