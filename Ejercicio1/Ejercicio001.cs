using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Ejercicio001
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int nro;
            int max = 0, min = 0, acum = 0, prom = 0;
            const int CANT = 5;

            for (int i = 0; i < CANT; i++)
            {
                Console.Write("NRO: ");
                while (!int.TryParse(Console.ReadLine(), out nro))
                    Console.Write("Nro no valido. Intente de nuevo. NRO: ");

                if (i == 0)
                    max = min = nro;
                else
                {
                    if (nro < min)
                        min = nro;

                    if (nro > max)
                        max = nro;

                    acum += nro;
                }
            }

            prom = acum / CANT;
            Console.WriteLine("\nMINIMO: {0}\nMAXIMO: {1}\nPROMEDIO:{2}", min, max, prom);
        }
    }
}
