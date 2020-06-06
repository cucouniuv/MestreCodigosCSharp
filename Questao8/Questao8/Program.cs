using System;
using System.Collections.Generic;

namespace Questao8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.");

            List<decimal> lista = new List<decimal>();

            while (true)
            {
                Console.WriteLine("Digite um valor decimal ou digite Parar:");
                string valor = Console.ReadLine();
                if (valor == "Parar")
                {
                    break;
                }

                bool teste = decimal.TryParse(valor, out decimal valordecimal);

                if (!(teste))
                {
                    Console.WriteLine("Valor decimal inválido.");
                }

                lista.Add(valordecimal);
            }

            lista.Sort();

            int i;

            Console.WriteLine("Valores em ordem crescente:");
            for (i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.WriteLine("Valores em ordem decrescente:");
            for (i = (lista.Count - 1); i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
