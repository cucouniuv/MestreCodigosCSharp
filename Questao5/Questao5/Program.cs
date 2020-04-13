using System;

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

            Console.WriteLine("Crie uma aplicação que calcule a fórmula de Bhaskara.");

            Console.WriteLine("Informe o valor de A:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de C:");
            c = int.Parse(Console.ReadLine());

            delta = (Math.Pow(b, 2) - 4 * a * c);

            //Console.WriteLine(delta);

            double x1;
            double x2;

            x1 = ((-b + Math.Sqrt(delta)) / (2 * a));

            x2 = ((-b - Math.Sqrt(delta)) / (2 * a));

            Console.WriteLine("Valor de X1 = {0} e X2 = {1}", x1, x2);

            //to-do: Tratar NaN
        }
    }
}
