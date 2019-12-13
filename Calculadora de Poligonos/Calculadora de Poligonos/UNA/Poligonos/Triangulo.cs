using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poligono
{
    public class Triangulo : Calculadora_de_Poligonos.Poligonos
    {
        public double Altura
        {
            get => default;
            set
            {
            }
        }

        public double Lado
        {
            get => default;
            set
            {
            }
        }

        public double Base
        {
            get => default;
            set
            {
            }
        }

        public double Lado1
        {
            get => default;
            set
            {
            }
        }

        public double Lado2
        {
            get => default;
            set
            {
            }
        }

        public Triangulo()
        {
            Nombre = "Triangulo";

        }
        public override double CalcularArea()
        {
            double area;
            return area = (Base * Altura)/2;
        }

        public override double CalcularPerimetro()
        {
            double perimetro;
            return perimetro = Lado + Lado1 + Lado2;
        }
    }
}