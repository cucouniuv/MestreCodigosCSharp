using System;
using System.Collections.Generic;

namespace Questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.");
            Console.WriteLine("Digite o primeiro valor:");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            int v3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor:");
            int v4 = int.Parse(Console.ReadLine());

            List<int> lista = new List<int> { v1, v2, v3, v4};

            int soma = 0;
            foreach (int x in lista)
            {
                if ((x % 2) == 0)
                    soma += x;
            }

            Console.WriteLine("Valor da soma: {0}", soma.ToString());
        }
    }
}
