using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que rea
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main()

*/

namespace Ejercicio014
{
    class Program
    {
        static void Main(string[] args)
        {
            const double LADO_CUADRADO = 10;
            const double ALTURA_TRIANGULO = 10;
            const double BASE_TRIANGULO = 5;
            const double RADIO_CIRCULO = 2;

            Console.WriteLine("AREA CUADRADO: {0}", CalculoDeArea.CalcularCuadrado(LADO_CUADRADO));
            Console.WriteLine("AREA TRIANGULO: {0}", CalculoDeArea.CalcularTriangulo(BASE_TRIANGULO, ALTURA_TRIANGULO));
            Console.WriteLine("AREA CIRCULO: {0}", CalculoDeArea.CalcularCirculo(RADIO_CIRCULO));

        }
    }
}
