using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio2
{
    class Ejercicio002
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";

            int nro;

            Console.Write("INGRESE UN NRO (>0): ");
            while (!int.TryParse(Console.ReadLine(), out nro) || nro < 0)
                Console.Write("ERROR. !Reingrese el numero¡");

            Console.WriteLine("\nCUADRADO: {0}\nCUBO: {1}", Math.Pow(nro, 2), Math.Pow(nro, 3));
        }
    }
}
