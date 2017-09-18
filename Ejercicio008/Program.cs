using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    8. Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
    trabajadas en el mes de ‗n‘ empleados de una fábrica.
    Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
    valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
    multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
    descuentos.
    Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
    bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
    Nota: Utilizar estructuras repetitivas y selectivas.
*/

namespace Ejercicio008
{
    class Program
    {
        struct Empleado
        {
            public int valorHora;
            public string nombre;
            public int antiguedad;
            public int cantidadHorasMes;
        }

        static void Main(string[] args)
        {
            int cantidadEmpleados;
            Empleado[] empleados;
            int auxTotal;
            StringBuilder listado = new StringBuilder();
            const int VALOR_ANTIGUEDAD = 150;

            Console.Write("CANTIDAD DE EMPLEADOS: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadEmpleados))
                Console.Write("Cantidad no válida. Intente de nuevo: ");

            empleados = new Empleado[cantidadEmpleados];

            //Carga de datos
            for (int i = 0; i < empleados.Count(); i++)
            {
                Console.WriteLine("CARGA DE DATOS:\n");
                Console.Write("NOMBRE: ");
                empleados[i].nombre = Console.ReadLine();
                Console.Write("VALOR POR HORA:");
                int.TryParse(Console.ReadLine(), out empleados[i].valorHora);
                Console.Write("ANTIGUEDAD: ");
                int.TryParse(Console.ReadLine(), out empleados[i].antiguedad);
                Console.Write("HORAS TRABAJADAS AL MES: ");
                int.TryParse(Console.ReadLine(), out empleados[i].cantidadHorasMes);
                Console.Clear();
            }
            
            foreach(Empleado unEmpleado in empleados)
            {
                auxTotal = (unEmpleado.valorHora * unEmpleado.cantidadHorasMes) + (unEmpleado.antiguedad * VALOR_ANTIGUEDAD);

                listado.AppendFormat("NOMBRE: {0}\nANTIGUEDAD: {1}\nHORAS TRABAJADAS: {2}\nTOTAL A COBRAR BRUTO: {3}\nTOTAL A COBRAR NETO: {4}"
                    , unEmpleado.nombre, unEmpleado.antiguedad, unEmpleado.cantidadHorasMes, auxTotal, auxTotal * 0.87);
                listado.Append("\n*************************\n");
            }

            Console.Clear();
            Console.WriteLine(listado.ToString());
        }
    }
}
