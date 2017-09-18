using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio004
{
    class Ejercicio004
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            const byte CANT = 4;
            byte contNrosPerfectos = 0;
            int contGral = 0, sumador = 0;

            while (contNrosPerfectos < CANT)
            {
                contGral++;
                for (int i = contGral -1 ; i > 0; i--)
                    if ((contGral % i) == 0)
                        sumador += i;
                    
                if (contGral == sumador)
                {
                    Console.WriteLine("NRO PERFECTO: {0}", contGral);
                    contNrosPerfectos++;
                }

                sumador = 0;
                
            }
        }
    }
}
