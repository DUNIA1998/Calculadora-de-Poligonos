using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Rectangulo : Calculadora_de_Poligonos.Poligonos
    {
        public double Largo
        {
            get => default;
            set
            {
            }
        }

        public double Ancho
        {
            get => default;
            set
            {
            }
        }

        public Rectangulo()
        {
            Nombre = "Rectangulo";

        }
        public override double CalcularArea()
        {
            double area;
            return area = Ancho * Largo;
        }

        public override double CalcularPerimetro()
        {

            double perimetro;
            return perimetro = (2 * Ancho) + (2 * Largo);
        }
    }
}