using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio015
{
    static class Calculadora
    {
        public static int Calcular(int operando1, int operando2, char operador)
        {
            int resultado;

            switch (operador)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
                case '/':
                    if (Validar(operando2))
                        resultado = operando1 / operando2;
                    else
                        resultado = 0;
                    break;
                default:
                    resultado = 0;
                    break;
            }

            return resultado;

        }

        private static bool Validar(int operando2)
        {
            bool auxReturn = false;

            if (operando2 != 0)
                auxReturn = true;

            return auxReturn;
        }

        public static void Mostrar(int resultado)
        {
            Console.WriteLine("RESULTADO: {0}", resultado);
        }
    }
}
