using System;
using System.Collections.Generic;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crie uma aplicação que receba nome e salario de N funcionários. Utilize a repetição for e while.");

            List<Funcionario> lista = new List<Funcionario>();

            while (true)
            {
                Console.WriteLine("Digite o nome do funcionário ou digite Parar:");
                string nome = Console.ReadLine();
                if (nome == "Parar")
                {
                    break;
                }
                Console.WriteLine("Digite o salário:");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Funcionario(nome, salario));
            }

            int i;
            double maiorSalario = 0;
            double menorSalario = 0;

            string nomeMaiorSalario = "";
            string nomeMenorSalario = "";

            for (i = 0; i < lista.Count; i++)
            {
                if (maiorSalario < lista[i].Salario)
                {
                    maiorSalario = lista[i].Salario;
                    nomeMaiorSalario = lista[i].Nome;
                }

                if (menorSalario == 0)
                {
                    menorSalario = lista[i].Salario;
                    nomeMenorSalario = lista[i].Nome;
                }

                if (menorSalario > lista[i].Salario)
                {
                    menorSalario = lista[i].Salario;
                    nomeMenorSalario = lista[i].Nome;
                }
            }

            Console.WriteLine("Maior Salário {0}: {1}", maiorSalario.ToString(), nomeMaiorSalario);
            Console.WriteLine("Menor Salário {0}: {1}", menorSalario.ToString(), nomeMenorSalario);
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
