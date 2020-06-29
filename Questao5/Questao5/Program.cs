using System;
using System.Globalization;

namespace Questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            double delta;

            Console.WriteLine("=====================================================");
            Console.WriteLine("Crie uma aplicação que calcule a fórmula de Bhaskara.");
            Console.WriteLine("=====================================================");

            Console.WriteLine("Informe o valor de A");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Informe o valor de A");

            Console.WriteLine("Informe o valor de B");
            while (!int.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Informe o valor de B");

            Console.WriteLine("Informe o valor de C");
            while (!int.TryParse(Console.ReadLine(), out c))
                Console.WriteLine("Informe o valor de C");

            delta = (Math.Pow(b, 2) - 4 * a * c);

            double x1;
            double x2;

            x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
            x2 = ((-b - Math.Sqrt(delta)) / (2 * a));

            Console.WriteLine("Valor de X1 = {0} e X2 = {1}", 
                (double.IsNaN(x1) ? "Indefinido" : x1.ToString()),
                (double.IsNaN(x2) ? "Indefinido" : x2.ToString())
                );
        }
    }
}
