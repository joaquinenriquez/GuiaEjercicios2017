using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
15. Realizar un programa que permita realizar operaciones matemáticas simples(suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar(pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea tres métodos estáticos(de clase):
a.Calcular(público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática.El método devolverá el resultado de la operación.
b.Validar(privado): Recibirá como parámetro el segundo número.Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO.
c.Mostrar (público): Este método recibe como parámetro el resultado de la operación y lo
muestra por pantalla.No posee valor de retorno.

*/

namespace Ejercicio015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            int opcion = 0;
            int operando1;
            int operando2;

            Console.WriteLine("CALCULADORA:\n");

            do
            {

                Console.WriteLine("1 - SUMA (+)");
                Console.WriteLine("2 - RESTA (-)");
                Console.WriteLine("3 - MULTIPLICACIÓN (*)");
                Console.WriteLine("4 - DIVISIÓN (/)");
                Console.WriteLine("5 - SALIR");

                Console.Write("\nOPCION: ");

                Console.Clear();
                Console.Write("OPERANDO 1:");
                int.TryParse(Console.ReadLine(), out operando1);
                Console.Write("OPERANDO 2:");
                int.TryParse(Console.ReadLine(), out operando2);


                int.TryParse(Console.ReadLine(), out opcion);
               

                switch (opcion)
                {
                    case 1:
                        Calculadora.Mostrar(Calculadora.Calcular(operando1, operando2, '+'));
                        break;
                    case 2:
                        Calculadora.Mostrar(Calculadora.Calcular(operando1, operando2, '-'));
                        break;
                    case 3:
                        Calculadora.Mostrar(Calculadora.Calcular(operando1, operando2, '*'));
                        break;
                    case 4:
                        Calculadora.Mostrar(Calculadora.Calcular(operando1, operando2, '/'));
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("OPCION NO VALIDA. INTENTE DE NUEVO");
                        break;
                }

              } while (opcion != 5);


        }
    }
}
