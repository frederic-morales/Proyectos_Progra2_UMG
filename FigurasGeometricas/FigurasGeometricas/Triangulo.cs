using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    public class Triangulo
    {
        public string Nombre;
        public int Lados = 3;
        public string Clasificacion;
        public double Base;
        public double Altura;
        public double perimetro;
        public double area;

        private void calcularArea()
        {
            area = (Base * Altura) / 2;
        }
    }

    public class Cuadrado
    {

    }
}
