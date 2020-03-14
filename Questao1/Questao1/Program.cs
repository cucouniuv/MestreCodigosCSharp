using System;

namespace Questao1
{
    class Program
    {
        public static double nResultadoAdicao;
        public static double nResultadoSubtracao;
        public static double nResultadoDivisao;
        public static double nResultadoMultiplicacao;
        public static string sAEhParOuImpar;
        public static string sBEhParOuImpar;

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
            nValorA = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            nValorB = Double.Parse(Console.ReadLine());
        }

        private static void ProcessarValores(double nValorA, double nValorB)
        {
            Program.nResultadoAdicao = nValorA + nValorB;
            Program.nResultadoSubtracao = nValorA - nValorB;
            Program.nResultadoDivisao = nValorB / nValorA;
            Program.nResultadoMultiplicacao = nValorA * nValorB;

            bool bValorAEhPar = (nValorA % 2 == 0);
            bool bValorBEhPar = (nValorB % 2 == 0);

            Program.sAEhParOuImpar = "ímpar";
            Program.sBEhParOuImpar = "ímpar";

            if (bValorAEhPar)
                sAEhParOuImpar = "par";
            if (bValorBEhPar)
                sBEhParOuImpar = "par";

            ExibirNoConsole();
        }

        private static void ExibirNoConsole()
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
                    Console.WriteLine("Opção 1 - Resultado: " + Program.nResultadoAdicao);
                    Console.WriteLine("");
                    ExibirNoConsole();
                    break;
                case "2":
                    Console.WriteLine("Opção 2 - Resultado: " + Program.nResultadoSubtracao);
                    Console.WriteLine("");
                    ExibirNoConsole();
                    break;
                case "3":
                    Console.WriteLine("Opção 3 - Resultado: " + Program.nResultadoDivisao);
                    Console.WriteLine("");
                    ExibirNoConsole();
                    break;
                case "4":
                    Console.WriteLine("Opção 4 - Resultado: " + Program.nResultadoMultiplicacao);
                    Console.WriteLine("");
                    ExibirNoConsole();
                    break;
                case "5":
                    Console.WriteLine("Opção 5 - Resultado: A é " + Program.sAEhParOuImpar + " e B é " + Program.sBEhParOuImpar);
                    Console.WriteLine("");
                    ExibirNoConsole();
                    break;
                case "6":
                    Console.WriteLine("Opção 1 - Resultado: " + Program.nResultadoAdicao);
                    Console.WriteLine("Opção 2 - Resultado: " + Program.nResultadoSubtracao);
                    Console.WriteLine("Opção 3 - Resultado: " + Program.nResultadoDivisao);
                    Console.WriteLine("Opção 4 - Resultado: " + Program.nResultadoMultiplicacao);
                    Console.WriteLine("Opção 5 - Resultado: A é " + Program.sAEhParOuImpar + " e B é " + Program.sBEhParOuImpar);
                    Console.WriteLine("");
                    ExibirNoConsole();
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
                    ExibirNoConsole();
                    break;
            }
        }
    }
}