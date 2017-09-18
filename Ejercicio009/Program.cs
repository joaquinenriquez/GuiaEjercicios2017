using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    9. Escribir un programa que imprima por pantalla una pirámide como
    la siguiente:
    *
    ***
    *****
    *******
    *********
    El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
    ejemplo anterior la altura ingresada fue de 5.
    Nota: Utilizar estructuras repetitivas y selectivas.

    */

namespace Ejercicio009
{
    class Program
    {
        static void Main(string[] args)
        {
            int alturaPiramide;

            Console.Title = "Ejercicio NRO 9";

            Console.Write("ALTURA DE LA PIRAMIDE: ");
            while (!int.TryParse(Console.ReadLine(), out alturaPiramide) || alturaPiramide < 0)
                Console.Write("Altura no válida. Intente de nuevo: ");

            for (int altura = 1; altura < alturaPiramide; altura++)
            {
                for (int ancho = 1; ancho < altura; ancho++)
                    Console.Write("*");
                Console.Write("\n");
            }

        }
    }
}
