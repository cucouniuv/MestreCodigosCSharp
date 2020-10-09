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

            Console.WriteLine("=====================================================");
            Console.WriteLine("Crie uma aplicação que calcule a fórmula de Bhaskara.");
            Console.WriteLine("=====================================================");

            Console.WriteLine(String.Empty);
            Console.WriteLine("Informe o valor de A");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Valor inválido. Informe o valor de A");

            Console.WriteLine(String.Empty);
            Console.WriteLine("Informe o valor de B");
            while (!int.TryParse(Console.ReadLine(), out b))
                Console.WriteLine("Valor inválido. Informe o valor de B");

            Console.WriteLine(String.Empty);
            Console.WriteLine("Informe o valor de C");
            while (!int.TryParse(Console.ReadLine(), out c))
                Console.WriteLine("Valor inválido. Informe o valor de C");

            Bhaskara bhaskara = new Bhaskara(a, b, c);
            double x1 = bhaskara.CalcularValorX1();
            double x2 = bhaskara.CalcularValorX2();

            Console.WriteLine(String.Empty);
            Console.WriteLine("Valor de X1 = {0} e X2 = {1}", 
                (double.IsNaN(x1) ? "Indefinido" : x1.ToString()),
                (double.IsNaN(x2) ? "Indefinido" : x2.ToString())
                );
        }
    }
}
