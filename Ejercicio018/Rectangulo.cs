using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {

        }

        public float Perimetro()
        {

        }

        public Rectangulo(Punto vertice1, Punto Vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            Math.Abs(vertice1.GetX() - vertice3.GetX());
        }
    }
}
