using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio014
{
    static class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return lado * lado;
        }

        public static double CalcularTriangulo(double ladoBase, double ladoAltura)
        {
            return (ladoBase * ladoAltura) / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }
    }

}
