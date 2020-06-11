using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListaInteiros = new List<int>() { 1, 5, 2, 3, 9, 7, 20, 18};

            //ListaInteiros.Add(2);
            //ListaInteiros.Add(4);
            //ListaInteiros.Add(5);
            //ListaInteiros.Add(8);

            // Imprimir todos os números da lista.
            Console.WriteLine("Imprimir todos os números da lista.");
            ListaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });

            //Imprimir todos os números da lista na ordem crescente.
            Console.WriteLine("Imprimir todos os números da lista na ordem crescente.");
            IEnumerable<int> ordemCrescente =
                from valor in ListaInteiros
                orderby valor ascending
                select valor;

            ordemCrescente.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });

            //Imprimir todos os números da lista na ordem decrescente.
            Console.WriteLine("Imprimir todos os números da lista na ordem decrescente.");
            IEnumerable<int> ordemDecrescente =
                from valor in ListaInteiros
                orderby valor descending
                select valor;

            ordemDecrescente.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });

            //Imprima apenas o primeiro número da lista
            Console.WriteLine("Imprima apenas o primeiro número da lista.");
            var primeiroRegistro =
                (from valor in ListaInteiros
                select valor)
                .First();

            Console.WriteLine(primeiroRegistro.ToString());

            //Imprima apenas o ultimo número da lista
            Console.WriteLine("Imprima apenas o ultimo número da lista.");
            var ultimoRegistro =
                (from valor in ListaInteiros
                 select valor)
                .Last();

            Console.WriteLine(ultimoRegistro.ToString());

            //Insira um numero no inicio da lista.
            // =========================== FAZER =============================
            Console.WriteLine("Insira um numero no inicio da lista.");


            //Insira um numero no final da lista.
            // =========================== FAZER =============================
            Console.WriteLine("Insira um numero no inicio da lista.");

            //Remova o primeiro número .
            // =========================== FAZER =============================
            Console.WriteLine("Insira um numero no inicio da lista.");

            //Remova o ultimo número .
            // =========================== FAZER =============================
            Console.WriteLine("Insira um numero no inicio da lista.");

            //Retorne apenas os número pares.
            //Retorne apenas o número informado.
            //Transforme todos os números da lista em um array.
        }
    }
}
