using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Pentagono : Calculadora_de_Poligonos.Poligonos
    {
        public double Lado
        {
            get => default;
            set
            {
            }
        }

        public double Apotema
        {
            get => default;
            set
            {
            }
        }
        public Pentagono()
        {
            Nombre = "Pentagono";

        }

        public override double CalcularArea()
        {
            double area;
            return area = ((5 * Lado) * Apotema) / 2;

        }

        public override double CalcularPerimetro()
        {
            double perimetro;
            return perimetro = 5 * Lado;
        }
    }
}