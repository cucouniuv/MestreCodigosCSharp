using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados");            
            Executar();
        }

        private static void Executar()
        {
            ReceberValores(out double nValorA, out double nValorB);
            ProcessarValores(nValorA, nValorB);
        }

        private static void ReceberValores(out double nValorA, out double nValorB)
        {
            Console.WriteLine("Digite o valor de A:");
            while (!(Double.TryParse(Console.ReadLine(), out nValorA)))
                Console.WriteLine("Digite o valor de A:");

            Console.WriteLine("Digite o valor de B:");
            while (!(Double.TryParse(Console.ReadLine(), out nValorB)))
                Console.WriteLine("Digite o valor de B:");
        }

        private static void ProcessarValores(double nValorA, double nValorB)
        {
            Processador processador = new Processador(nValorA, nValorB);

            ExibirNoConsole(processador);
        }

        private static void ExibirNoConsole(Processador p)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("==            Menu de opções            ==");
            Console.WriteLine("==========================================");
            Console.WriteLine("1 - Exibir soma dos valores");
            Console.WriteLine("2 - Exibir subtração de A - B");
            Console.WriteLine("3 - Exibir divisão de B por A");
            Console.WriteLine("4 - Exibir multiplicação de A com B");
            Console.WriteLine("5 - Exibir se os valores são pares/ímpares");
            Console.WriteLine("6 - Exibir todos os resultados");
            Console.WriteLine("7 - Digitar novos valores");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("==========================================");

            Console.WriteLine("Digite o número da opção desejada:");
            string sValorEscolhido = Console.ReadLine();

            switch (sValorEscolhido)
            {
                case "1":
                    Console.WriteLine("Opção 1 - Resultado: " + p.Adicao());
                    Console.WriteLine("");
                    ExibirNoConsole(p);
                    break;
                case "2":
                    Console.WriteLine("Opção 2 - Resultado: " + p.Subtracao());
                    Console.WriteLine("");
                    ExibirNoConsole(p);
                    break;
                case "3":
                    Console.WriteLine("Opção 3 - Resultado: " + p.Divisao());
                    Console.WriteLine("");
                    ExibirNoConsole(p);
                    break;
                case "4":
                    Console.WriteLine("Opção 4 - Resultado: " + p.Multiplicacao());
                    Console.WriteLine("");
                    ExibirNoConsole(p);
                    break;
                case "5":
                    Console.WriteLine("Opção 5 - Resultado: A é " + p.ValorAEhParOuImpar + " e B é " + p.ValorBEhParOuImpar);
                    Console.WriteLine("");
                    ExibirNoConsole(p);
                    break;
                case "6":
                    Console.WriteLine("Opção 1 - Resultado: " + p.Adicao());
                    Console.WriteLine("Opção 2 - Resultado: " + p.Subtracao());
                    Console.WriteLine("Opção 3 - Resultado: " + p.Divisao());
                    Console.WriteLine("Opção 4 - Resultado: " + p.Multiplicacao());
                    Console.WriteLine("Opção 5 - Resultado: A é " + p.ValorAEhParOuImpar + " e B é " + p.ValorBEhParOuImpar);
                    Console.WriteLine("");
                    ExibirNoConsole(p);
                    break;
                case "7":
                    Console.Clear();
                    Executar();
                    break;
                case "8":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Opção não disponível. Tente Novamente.");
                    Console.WriteLine("");
                    ExibirNoConsole(p);
                    break;
            }
        }
    }
}