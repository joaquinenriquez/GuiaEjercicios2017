using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio016
{
    class Alumno
    {
        #region Atributos
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public int legajo;
        public string nombre;
        #endregion

        #region Métodos Públicos
        public void CalcularFinal()
        {
            Random auxNota = new Random();

            if ((this.nota1 >= 4) && (this.nota2 >= 4))
                this.notaFinal = auxNota.Next();
            else
                this.notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void Mostrar()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendFormat("ALUMNO: {0}", this.nombre);
            salida.AppendFormat("\nNOTA 1: {0}", this.nota1);
            salida.AppendFormat("\nNOTA 2: {0}", this.nota2);
            if (this.notaFinal != -1)
                salida.AppendFormat("\nNOTA FINAL: ", this.notaFinal);
            else
                salida.AppendFormat("\nNOTA FINAL: ALUMNO DESAPROBADO");


            Console.Write(salida.ToString());
        }

        

        
        
        #endregion

    }
}
