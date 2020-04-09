using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while.");

            ExibirMultiplosDeTres();
        }

        private static void ExibirMultiplosDeTres()
        {
            int nContador = 1;

            while (nContador <= 100)
            {
                if ((nContador % 3) == 0) {
                    Console.WriteLine(nContador);
                }
                nContador++;
            }
        }
    }
}
