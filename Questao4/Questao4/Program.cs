using System;
using System.Collections.Generic;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça uma aplicação que receba N alunos com suas respectivas notas. Use foreach para estrutura de repetição.");

            List<Alunos> alunos = new List<Alunos>();

            while (true)
            {
                Console.WriteLine("Digite o nome do aluno ou digite Parar:");
                string nome = Console.ReadLine();
                if (nome == "Parar")
                {
                    break;
                }
                Console.WriteLine("Digite a nota 1:");
                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a nota 2:");
                double nota2 = double.Parse(Console.ReadLine());

                alunos.Add(new Alunos(nome, nota1, nota2));
            }

            foreach (Alunos aluno in alunos)
            {
                if (aluno.Media >= 7)
                    Console.WriteLine("Nome: {0} - Média: {1}", aluno.Nome, aluno.Media);
            }
        }
    }

    class Alunos
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Media
    {
            get => PegarMedia();
        }

        double PegarMedia()
        {
            return ((Nota1 + Nota2) / 2);
        }

        public Alunos(string nome, double nota1, double nota2)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
        }
    }
}
