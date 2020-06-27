using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInteiros = new List<int>() { 1, 5, 2, 3, 9, 7, 20, 18};

            // Imprimir todos os números da lista.
            Console.WriteLine("Imprimir todos os números da lista.");
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });

            //Imprimir todos os números da lista na ordem crescente.
            Console.WriteLine("Imprimir todos os números da lista na ordem crescente.");
            IEnumerable<int> ordemCrescente =
                from valor in listaInteiros
                orderby valor ascending
                select valor;

            ordemCrescente.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });

            //Imprimir todos os números da lista na ordem decrescente.
            Console.WriteLine("Imprimir todos os números da lista na ordem decrescente.");
            IEnumerable<int> ordemDecrescente =
                from valor in listaInteiros
                orderby valor descending
                select valor;

            ordemDecrescente.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });

            //Imprima apenas o primeiro número da lista
            Console.WriteLine("Imprima apenas o primeiro número da lista.");
            var primeiroRegistro =
                (from valor in listaInteiros
                select valor)
                .First();

            Console.WriteLine(primeiroRegistro.ToString());

            //Imprima apenas o ultimo número da lista
            Console.WriteLine("Imprima apenas o ultimo número da lista.");
            var ultimoRegistro =
                (from valor in listaInteiros
                 select valor)
                .Last();

            Console.WriteLine(ultimoRegistro.ToString());

            //Insira um numero no inicio da lista.
            Console.WriteLine("Insira um número no início da lista.");
            listaInteiros.Insert(0, 99);
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });

            //Insira um numero no final da lista.
            Console.WriteLine("Insira um numero no final da lista.");
            var finalLista = listaInteiros;
            finalLista.Add(88);
            finalLista.ForEach(x => { Console.WriteLine(x.ToString()); });

            //Remova o primeiro número.
            Console.WriteLine("Remova o primeiro número.");
            var removaPrimeiro = listaInteiros.Skip(1).ToList();
            removaPrimeiro.ForEach(x => { Console.WriteLine(x.ToString()); });

            //Remova o ultimo número.
            Console.WriteLine("Remova o último número.");
            var removaUltimo = listaInteiros.Take(listaInteiros.Count() - 1).ToList();
            removaUltimo.ForEach(x => { Console.WriteLine(x.ToString()); });

            //Retorne apenas os número pares.
            Console.WriteLine("Retorne apenas os número pares.");
            var numerosPares =
                (from valor in listaInteiros
                where (valor % 2) == 0
                select valor);
            numerosPares.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });

            //Retorne apenas o número informado.
            Console.WriteLine("Retorne apenas o número informado.");
            int numeroInformado = 20;
            var listaNumeroInformado =
                (from valor in listaInteiros
                 where valor == numeroInformado
                 select valor);
            listaNumeroInformado.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });

            //Transforme todos os números da lista em um array.
            Console.WriteLine("Transforme todos os números da lista em um array.");
            foreach (int valor in listaInteiros.ToArray())
            {
                Console.WriteLine(valor);
            }

        }
    }
}
