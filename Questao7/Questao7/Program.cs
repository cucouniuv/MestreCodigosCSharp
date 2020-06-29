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

            int v1, v2, v3, v4;

            Console.WriteLine("Digite o primeiro valor");
            while (!int.TryParse(Console.ReadLine(), out v1))
                Console.WriteLine("Digite o primeiro valor");

            Console.WriteLine("Digite o segundo valor");           
            while (!int.TryParse(Console.ReadLine(), out v2))
                Console.WriteLine("Digite o segundo valor");

            Console.WriteLine("Digite o terceiro valor");            
            while (!int.TryParse(Console.ReadLine(), out v3))
                Console.WriteLine("Digite o terceiro valor");

            Console.WriteLine("Digite o quarto valor");            
            while (!int.TryParse(Console.ReadLine(), out v4))
                Console.WriteLine("Digite o quarto valor");

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
