using System;
using System.Collections.Generic;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================================================================");
            Console.WriteLine("Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.");
            Console.WriteLine("===============================================================================================");

            List<decimal> lista = new List<decimal>();

            while (true)
            {
                Console.WriteLine("Digite um valor decimal ou digite exatamente Parar");
                string valorInformado = Console.ReadLine();

                if (valorInformado == "Parar")
                    break;

                if (!decimal.TryParse(valorInformado, out decimal valorDecimal))
                {
                    Console.WriteLine("Valor inválido.");
                    continue;
                }

                lista.Add(valorDecimal);
            }

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há valores para exibir");
                return;
            }

            lista.Sort();

            int i;

            Console.WriteLine("Valores em ordem crescente");
            for (i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("");

            Console.WriteLine("Valores em ordem decrescente");
            for (i = (lista.Count - 1); i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
