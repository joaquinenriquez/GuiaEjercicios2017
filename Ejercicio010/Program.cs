using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
    Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, que
    posea la siguiente firma: bool Validar(int valor, int min, int max):
    a. valor: dato a validar
    b. min y max: rango en el cual deberá estar la variable valor.
    Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
    Nota: Utilizar variables escalares, NO utilizar vectores.
*/

namespace Ejercicio010
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroActual;
            int min = 0;
            int max = 0;
            float promedio;
            int sumador = 0;
            StringBuilder salida = new StringBuilder();

            const int CANT_NUMEROS = 5;

            for (int i = 0; i < CANT_NUMEROS; i++)
            {

                Console.Write("Numero: ");
                while ((!int.TryParse(Console.ReadLine(), out nroActual)) || (!Validacion.Validar(nroActual,100,-100)))
                    Console.Write("NRO no válido. Intente de nuevo: ");

                if (i == 0)
                {
                    max = nroActual;
                    min = nroActual;
                }

                if (nroActual > max)
                    max = nroActual;

                if (nroActual < min)
                    min = nroActual;

                sumador += nroActual;
            }

            Console.Clear();
            
            promedio = sumador / CANT_NUMEROS;
            salida.AppendFormat("MÁXIMO: {0}\nMÍNIMO: {1}\nPROMEDIO: {2}", max, min, promedio);

            Console.Write(salida.ToString());

        }
    }
}
