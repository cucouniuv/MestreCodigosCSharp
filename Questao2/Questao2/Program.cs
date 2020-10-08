using System;
using System.Collections.Generic;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação que receba nome e salario de N funcionários. Utilize a repetição for e while.");

            List<Funcionario> listaFuncionario = new List<Funcionario>();

            while (true)
            {
                const string frase = "Digite o nome do funcionário ou digite exatamente: Parar";
                Console.WriteLine(frase);
                string nome;
                while ((nome = Console.ReadLine()).Length == 0)
                    Console.WriteLine(frase);

                if (nome == "Parar")
                    break;

                double salario;
                Console.WriteLine("Digite o salário:");
                while ((!double.TryParse(Console.ReadLine(), out salario)) || (salario < 0))
                    Console.WriteLine("Valor inválido. Digite o salário:");

                listaFuncionario.Add(new Funcionario(nome, salario));
            }

            if (listaFuncionario.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário informado");
                return;
            }

            Funcionario.DefinirFuncionarioComMaiorEMenorSalarioDeUmaLista(listaFuncionario,
                out Funcionario funcionarioMaiorSalario, out Funcionario funcionarioMenorSalario);

            Console.WriteLine(String.Empty);
            Console.WriteLine("Maior Salário {0} - Funcionário {1}", 
                funcionarioMaiorSalario.Salario.ToString("N2"), funcionarioMaiorSalario.Nome);
            Console.WriteLine("Menor Salário {0} - Funcionário {1}", 
                funcionarioMenorSalario.Salario.ToString("N2"), funcionarioMenorSalario.Nome);
        }
    }
}
