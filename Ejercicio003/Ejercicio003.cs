using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio003
{
    class Ejercicio003
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercico Nro 3";

            int nro;
            bool esPrimo = true;


            Console.Write("Ingrese un NRO: ");
            while (!int.TryParse(Console.ReadLine(), out nro))
                Console.Write("Nro no valido. Intente de nuevo. NRO: ");

            for (int i = nro; i > 1; i--)
            {
                esPrimo = true;
                for (int j = i - 1; j > 0; j--)
                {
                    if ((i % j == 0) && j != 1)
                        esPrimo = false;
                }

                if (esPrimo)
                    Console.WriteLine("El NRO: {0} es primo", i);
                else
                    Console.WriteLine("El NRO: {0} no es primo", i);
            }
        }
    }
}
