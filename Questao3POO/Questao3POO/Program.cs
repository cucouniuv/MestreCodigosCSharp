using System;

namespace Questao3POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutarOperacoesContaCorrente();

            ExecutarOperacoesContaEspecial();
        }

        private static void ExecutarOperacoesContaEspecial()
        {
            ContaEspecial contaEspecial = new ContaEspecial();
            try
            {
                Console.WriteLine(String.Empty);

                contaEspecial.NumeroConta = 81211;
                contaEspecial.Limite = 500;

                contaEspecial.Depositar(10);
                contaEspecial.Sacar(490);
                Console.WriteLine(contaEspecial.MostrarDados());
                Console.WriteLine(String.Empty);

                contaEspecial.Sacar(600);
                Console.WriteLine(contaEspecial.MostrarDados());
                Console.WriteLine(String.Empty);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ExecutarOperacoesContaCorrente()
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            try
            {
                Console.WriteLine(String.Empty);

                contaCorrente.NumeroConta = 50259;

                contaCorrente.Depositar(100.23);
                contaCorrente.Sacar(50);
                Console.WriteLine(contaCorrente.MostrarDados());
                Console.WriteLine(String.Empty);

                contaCorrente.Sacar(200);
                Console.WriteLine(contaCorrente.MostrarDados());
                Console.WriteLine(String.Empty);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
