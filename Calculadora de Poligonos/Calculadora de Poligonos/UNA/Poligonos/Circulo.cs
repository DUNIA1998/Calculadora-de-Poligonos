using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Circulo : Calculadora_de_Poligonos.Poligonos
    {
        public double Radio
        {
            get => default;
            set
            {
            }
        }

        public Circulo()
        {
            Nombre = "Circulo";

        }

        public override double CalcularArea()
        {
            double area;
            return area = (Math.PI * Math.Pow(Radio, 2));
        }
        public override double CalcularPerimetro()
        {
            double perimetro;
            return perimetro = (2 * Math.PI) * Radio;
        }
    }
}