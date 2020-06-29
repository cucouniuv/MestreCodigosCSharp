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


            Console.WriteLine("===================================");
            Console.WriteLine("Imprimir todos os números da lista.");
            Console.WriteLine("===================================");
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Imprimir todos os números da lista na ordem crescente.");
            Console.WriteLine("===================================");
            IEnumerable<int> ordemCrescente =
                from valor in listaInteiros
                orderby valor ascending
                select valor;

            ordemCrescente.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Imprimir todos os números da lista na ordem decrescente.");
            Console.WriteLine("===================================");
            IEnumerable<int> ordemDecrescente =
                from valor in listaInteiros
                orderby valor descending
                select valor;

            ordemDecrescente.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Imprima apenas o primeiro número da lista.");
            Console.WriteLine("===================================");
            var primeiroRegistro =
                (from valor in listaInteiros
                select valor)
                .First();

            Console.WriteLine(primeiroRegistro.ToString());


            Console.WriteLine("===================================");
            Console.WriteLine("Imprima apenas o ultimo número da lista.");
            Console.WriteLine("===================================");
            var ultimoRegistro =
                (from valor in listaInteiros
                 select valor)
                .Last();

            Console.WriteLine(ultimoRegistro.ToString());


            Console.WriteLine("===================================");
            Console.WriteLine("Insira um número no início da lista.");
            Console.WriteLine("===================================");
            var inicioLista = listaInteiros.ToList();
            inicioLista.Insert(0, 99);
            inicioLista.ForEach(x => { Console.WriteLine(x.ToString()); });

            Console.WriteLine("===================================");
            Console.WriteLine("Insira um numero no final da lista.");
            Console.WriteLine("===================================");
            var finalLista = listaInteiros.ToList();
            finalLista.Add(88);
            finalLista.ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Remova o primeiro número.");
            Console.WriteLine("===================================");
            var removaPrimeiro = listaInteiros.Skip(1).ToList();
            removaPrimeiro.ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Remova o último número.");
            Console.WriteLine("===================================");
            var removaUltimo = listaInteiros.Take(listaInteiros.Count() - 1).ToList();
            removaUltimo.ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Retorne apenas os número pares.");
            Console.WriteLine("===================================");
            var numerosPares =
                (from valor in listaInteiros
                where (valor % 2) == 0
                select valor);
            numerosPares.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Retorne apenas o número informado.");
            Console.WriteLine("===================================");
            int numeroInformado = 20;
            var listaNumeroInformado =
                (from valor in listaInteiros
                 where valor == numeroInformado
                 select valor);
            listaNumeroInformado.ToList().ForEach(x => { Console.WriteLine(x.ToString()); });


            Console.WriteLine("===================================");
            Console.WriteLine("Transforme todos os números da lista em um array.");
            Console.WriteLine("===================================");
            foreach (int valor in listaInteiros.ToArray())
            {
                Console.WriteLine(valor);
            }

        }
    }
}
