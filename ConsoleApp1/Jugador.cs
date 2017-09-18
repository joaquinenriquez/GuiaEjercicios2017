using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Jugador
    {
        #region Atributos
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        #endregion

        #region Constructores
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        private Jugador(string nombre)
        {

        }

        private Jugador(string nombre, int totalGoles, int totalPartidos)
        {

        }
        #endregion

        #region Métodos públicos
        public string MostrarDatos()
        {
            return "";
        }

        public float GetPromedioGoles()
        {
            float promedioGoles = 
            this.totalGoles / this.partidosJugados;

            return promedioGoles;
        }


        #endregion

        #region Redefinición de operadores
        //==
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            bool auxReturn = false;

            if (jugador1.dni == jugador2.dni)
                auxReturn = true;

            return auxReturn;
        }


        //!=
        #endregion
    }
}
