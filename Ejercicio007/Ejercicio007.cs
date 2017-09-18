using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que pida por pantalla la fecha de nacimiento 
 * de una persona (día, mes y año) y calcule el número de días 
 * vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con 
 * DateTime.Now).
 * Nota: Utilizar estructuras selectivas. 
 * Tener en cuenta los años bisiestos.
 */


namespace Ejercicio007
{
    class Ejercicio007
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";

            DateTime fechaNacimiento;
            //Nos traemos la fecha actual del sistema
            DateTime fechaActual = DateTime.Now;

            Console.Write("Fecha de nacimiento: ");

            //Validamos que la fecha ingresada tenga formato valido y que sea posterior a la actual
            while ((!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento)) || (DateTime.Compare(fechaActual, fechaNacimiento) < 0))
                Console.Write("Fecha no válida. Intente de nuevo: ");

            //La resta de dos DateTime nos devuelve la diferencia en dias
            Console.WriteLine("Dias vividos hasta hoy: {0}", fechaActual - fechaNacimiento);
         
        }
    }
}
