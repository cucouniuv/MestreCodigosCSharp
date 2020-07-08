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
                while (!(double.TryParse(Console.ReadLine(), out salario)))
                    Console.WriteLine("Digite o salário:");

                listaFuncionario.Add(new Funcionario(nome, salario));
            }

            int i;
            double maiorSalario = 0;
            double menorSalario = 0;

            string nomeMaiorSalario = "";
            string nomeMenorSalario = "";

            for (i = 0; i < listaFuncionario.Count; i++)
            {
                if (maiorSalario < listaFuncionario[i].Salario)
                {
                    maiorSalario = listaFuncionario[i].Salario;
                    nomeMaiorSalario = listaFuncionario[i].Nome;
                }

                if (menorSalario == 0)
                {
                    menorSalario = listaFuncionario[i].Salario;
                    nomeMenorSalario = listaFuncionario[i].Nome;
                }

                if (menorSalario > listaFuncionario[i].Salario)
                {
                    menorSalario = listaFuncionario[i].Salario;
                    nomeMenorSalario = listaFuncionario[i].Nome;
                }
            }

            Console.WriteLine("Maior Salário {0} - Funcionário {1}", maiorSalario.ToString("N2"), nomeMaiorSalario);
            Console.WriteLine("Menor Salário {0} - Funcionário {1}", menorSalario.ToString("N2"), nomeMenorSalario);
        }

        class Funcionario
        {
            public string Nome { get; set; }
            public double Salario { get; set; }

            public Funcionario(string nome, double salario)
            {
                Nome = nome;
                Salario = salario;
            }
        }
    }
}
