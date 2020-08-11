using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Triangulo
    {
        public double A;
        public double C;
        public double B;

        public double CalcularArea() { 
        
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }

    }
}
