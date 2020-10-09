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
                contaEspecial.NumeroConta = 81211;
                contaEspecial.Limite = 500;
                contaEspecial.Depositar(10);

                contaEspecial.Sacar(490);
                Console.WriteLine(contaEspecial.MostrarDados());

                contaEspecial.Sacar(600);
                Console.WriteLine(contaEspecial.MostrarDados());
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
                contaCorrente.NumeroConta = 50259;
                contaCorrente.Depositar(100.23);

                contaCorrente.Sacar(50);
                Console.WriteLine(contaCorrente.MostrarDados());

                contaCorrente.Sacar(200);
                Console.WriteLine(contaCorrente.MostrarDados());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
