using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
12. Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso deopciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.
*/

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumador = 0;

            do
            {
                Console.Clear();
                Console.Write("NUMERO: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                    Console.Write("NUMERO NO VALIDO! INTENTE DE NUEVO: ");

                sumador += numero;

                Console.WriteLine("SUMA: {0}", sumador);

                Console.Write("Desea continuar? (S/N): ");
                
            } while (ValidarRespuesta.ValidarS_N(Console.ReadKey().KeyChar));



       

        }
    }
}
