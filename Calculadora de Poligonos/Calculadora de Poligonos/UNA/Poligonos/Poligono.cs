using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_de_Poligonos
{
    public abstract class Poligonos
    {
        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

    }
}