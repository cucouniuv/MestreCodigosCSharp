using System;

namespace Questao4POO
{
    class Program
    {
        public static Televisao tv;
        public static ControleRemoto controleRemoto;

        static void Main(string[] args)
        {
            Executar();
        }

        private static void Executar()
        {
            tv = new Televisao();
            controleRemoto = new ControleRemoto(tv);
            ExibirOpcoes();
        }

        private static void ExibirOpcoes()
        {
            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine("==           Controle remoto            ==");
            Console.WriteLine("==========================================");
            Console.WriteLine("1 - Aumentar volume");
            Console.WriteLine("2 - Diminuir volume");
            Console.WriteLine("3 - Aumentar número do canal");
            Console.WriteLine("4 - Diminuir número do canal");
            Console.WriteLine("5 - Informar um número de canal");
            Console.WriteLine("6 - Consultar volume e canal");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("==========================================");
            Console.WriteLine("");

            Console.WriteLine("Digite o número da opção desejada:");
            string sValorEscolhido = Console.ReadLine();

            switch (sValorEscolhido)
            {
                case "1":
                    controleRemoto.AumentarVolume();
                    Console.WriteLine("Volume: {0}", tv.Volume);
                    ExibirOpcoes();
                    break;
                case "2":
                    controleRemoto.DiminuirVolume();
                    Console.WriteLine("Volume: {0}", tv.Volume);
                    ExibirOpcoes();
                    break;
                case "3":
                    Console.WriteLine("{0}", controleRemoto.AumentarNumeroCanal());
                    ExibirOpcoes();
                    break;
                case "4":
                    Console.WriteLine("{0}", controleRemoto.DiminuirNumeroCanal());
                    ExibirOpcoes();
                    break;
                case "5":
                    Console.WriteLine("Qual número de canal?");
                    int numeroCanal = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0}", controleRemoto.InformarNumeroCanal(numeroCanal));
                    ExibirOpcoes();
                    break;
                case "6":
                    Console.WriteLine("{0}", controleRemoto.ConsultarInfoVolumeCanal());
                    ExibirOpcoes();
                    break;
                case "7":
                    break;
            }
        }
    }
}
