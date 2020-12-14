using System;

namespace PrimeiroProj
{
    class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public Triangulo()
        {

        }
        public Triangulo(double _ladoA, double _ladoB, double _ladoC)
        {
            this.LadoA = _ladoA;
            this.LadoB = _ladoB;
            this.LadoC = _ladoC;
        }

        public double Area()
        {
            double p = (this.LadoA + this.LadoB + this.LadoC) / 2.0;
            return Math.Sqrt(p * (p - this.LadoA) * (p - this.LadoB) * (p - this.LadoC));
        }
    }
}
