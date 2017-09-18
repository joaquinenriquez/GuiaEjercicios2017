using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*6. Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 
100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Nota: Utilizar estructuras repetitivas, selectivas y la 
función módulo (%).*/



namespace Ejercicio006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";

            int año;
            bool esBisiesto = false;

            Console.Write("AÑO: ");
            while (!int.TryParse(Console.ReadLine(), out año))
                Console.Write("Año no valido. Intente de nuevo");

            if (año % 4 == 0)
                if (año % 100 == 0)
                {
                    if (año % 400 == 0)
                        esBisiesto = true;
                }
                else
                    esBisiesto = true;


            if (esBisiesto)
                Console.WriteLine("Es bisiesto!");
            else
                Console.WriteLine("No Es bisiesto!");

            Console.Write("Quiere consultar otro año?");

        }
    }
}
