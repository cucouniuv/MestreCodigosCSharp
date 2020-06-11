using System;

namespace Questao2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Informe o nome da pessoa:");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe a data de nascimento da pessoa:");
            pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da pessoa:");
            pessoa.Altura = Decimal.Parse(Console.ReadLine());

            Console.WriteLine(pessoa.ImprimirDados());
        }
    }
}
