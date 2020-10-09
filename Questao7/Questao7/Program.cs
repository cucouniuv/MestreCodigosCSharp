using System;
using System.Collections.Generic;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================");
            Console.WriteLine("Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.");
            Console.WriteLine("================================================================================");

            int[] valores = new int[4];

            Console.WriteLine("Digite o primeiro valor");
            while (!int.TryParse(Console.ReadLine(), out valores[0]))
                Console.WriteLine("Digite o primeiro valor");

            Console.WriteLine("Digite o segundo valor");           
            while (!int.TryParse(Console.ReadLine(), out valores[1]))
                Console.WriteLine("Digite o segundo valor");

            Console.WriteLine("Digite o terceiro valor");            
            while (!int.TryParse(Console.ReadLine(), out valores[2]))
                Console.WriteLine("Digite o terceiro valor");

            Console.WriteLine("Digite o quarto valor");            
            while (!int.TryParse(Console.ReadLine(), out valores[3]))
                Console.WriteLine("Digite o quarto valor");

            int soma = 0;
            foreach (int x in valores)
            {
                if (ValorEhPar(x))
                    soma += x;
            }

            Console.WriteLine("");
            Console.WriteLine("Valor da soma: {0}", soma.ToString());
        }

        private static bool ValorEhPar(int valor) => ((valor % 2) == 0);
    }
}
