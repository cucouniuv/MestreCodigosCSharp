using System;
using System.Collections.Generic;
using System.Linq;

namespace Questao9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInteiros = new List<int>();

            const string frase = "Digite um número inteiro ou digite exatamente: Parar";

            while (true)
            {
                Console.WriteLine(frase);

                string valorDigitado;
                int valorInteiro;

                while
                    (
                        ((valorDigitado = Console.ReadLine()).Length == 0) ||
                        ((!int.TryParse(valorDigitado, out valorInteiro)) && (valorDigitado != "Parar"))
                    )
                    Console.WriteLine("Valor inválido. " + frase);

                if (valorDigitado == "Parar")
                    break;

                listaInteiros.Add(valorInteiro);
            }

            ExibirTituloNoConsole("Imprimir todos os números da lista.");
            ExibirTodosOsNumerosDaLista(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Imprimir todos os números da lista na ordem crescente.");
            ExibirTodosOsNumerosDaListaEmOrdemCrescente(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Imprimir todos os números da lista na ordem decrescente.");
            ExibirTodosOsNumerosDaListaEmOrdemDescrescente(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Imprima apenas o primeiro número da lista.");
            ExibirApenasOPrimeiroNumeroDaLista(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Imprima apenas o ultimo número da lista.");
            ExibirApenasOUltimoNumeroDaLista(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Insira um número no início da lista.");
            ExibirListaComNumeroInseridoNoInicio(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Insira um número no final da lista.");
            ExibirListaComNumeroInseridoNoFinal(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Remova o primeiro número.");
            ExibirListaRemovendoOPrimeiroNumero(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Remova o último número.");
            ExibirListaRemovendoOUltimoNumero(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Retorne apenas os número pares.");
            ExibirApenasOsNumerosParesDaLista(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Retorne apenas o número informado.");
            ExibirApenasONumeroInformadoDaLista(listaInteiros);
            Console.WriteLine(String.Empty);

            ExibirTituloNoConsole("Transforme todos os números da lista em um array.");
            ExibirTodosOsNumerosDaListaEmArray(listaInteiros);

        }

        private static void ExibirTodosOsNumerosDaListaEmArray(List<int> listaInteiros)
        {
            foreach (int valor in listaInteiros.ToArray())
            {
                Console.WriteLine(valor);
            }
        }

        private static void ExibirApenasONumeroInformadoDaLista(List<int> listaInteiros)
        {
            int valorInformado;
            while (!int.TryParse(Console.ReadLine(), out valorInformado))
                Console.WriteLine("Valor inválido. Digite um número inteiro");

            Console.WriteLine(String.Empty);
            listaInteiros.Where(x => x == valorInformado).ToList()
                .ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirApenasOsNumerosParesDaLista(List<int> listaInteiros)
        {
            listaInteiros.Where(x => ((x % 2) == 0)).ToList()
                .ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirListaRemovendoOUltimoNumero(List<int> listaInteiros)
        {
            listaInteiros.RemoveAt(listaInteiros.Count - 1);
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirListaRemovendoOPrimeiroNumero(List<int> listaInteiros)
        {
            listaInteiros.RemoveAt(0);
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirListaComNumeroInseridoNoFinal(List<int> listaInteiros)
        {
            int valorFim;
            while (!int.TryParse(Console.ReadLine(), out valorFim))
                Console.WriteLine("Valor inválido. Digite um número inteiro");

            listaInteiros.Add(valorFim);

            Console.WriteLine(String.Empty);
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirListaComNumeroInseridoNoInicio(List<int> listaInteiros)
        {
            Console.WriteLine("Digite um número inteiro");
            int valorInicio;
            while (!int.TryParse(Console.ReadLine(), out valorInicio))
                Console.WriteLine("Valor inválido. Digite um número inteiro");

            listaInteiros.Insert(0, valorInicio);

            Console.WriteLine(String.Empty);
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirApenasOUltimoNumeroDaLista(List<int> listaInteiros)
        {
            Console.WriteLine(listaInteiros.Last().ToString());
        }

        private static void ExibirApenasOPrimeiroNumeroDaLista(List<int> listaInteiros)
        {
            Console.WriteLine(listaInteiros.First().ToString());
        }

        private static void ExibirTodosOsNumerosDaListaEmOrdemDescrescente(List<int> listaInteiros)
        {
            listaInteiros.OrderByDescending(x => x).ToList()
                .ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirTodosOsNumerosDaListaEmOrdemCrescente(List<int> listaInteiros)
        {
            listaInteiros.OrderBy(x => x).ToList()
                .ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirTodosOsNumerosDaLista(List<int> listaInteiros)
        {
            listaInteiros.ForEach(x => { Console.WriteLine(x.ToString()); });
        }

        private static void ExibirTituloNoConsole(string titulo)
        {
            Console.WriteLine("===================================");
            Console.WriteLine(titulo);
            Console.WriteLine("===================================");
        }
    }
}
