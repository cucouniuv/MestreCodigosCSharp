using System;
using System.Collections.Generic;
using System.Text;

namespace Questao5
{
    public class Bhaskara
    {
        public Bhaskara(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            Delta = (Math.Pow(B, 2) - 4 * A * C);
        }

        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        private readonly double Delta;

        public double CalcularValorX1()
        {
            double valor = (-B + Math.Sqrt(Delta)) / (2 * A);
            return Math.Truncate(100 * valor) / 100;
        }

        public double CalcularValorX2()
        {
            double valor = (-B - Math.Sqrt(Delta)) / (2 * A);
            return Math.Truncate(100 * valor) / 100;
        }

    }
}
