using System;
using System.Collections.Generic;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.Write("Faça uma aplicação que receba N alunos com suas respectivas notas. ");
            Console.WriteLine("Use foreach para estrutura de repetição.");
            Console.WriteLine("======================================");
            

            List<Alunos> listaAlunos = new List<Alunos>();

            while (true)
            {
                Console.WriteLine("Digite o nome do aluno ou digite exatamente Parar");
                string nome;
                
                while ((nome = Console.ReadLine()).Length == 0)
                    Console.WriteLine("Digite o nome do aluno ou digite exatamente Parar");

                if (nome == "Parar")
                    break;

                Console.WriteLine("Digite a nota 1. [Entre 0-10]");
                double nota1;

                while ((!double.TryParse(Console.ReadLine(), out nota1)) || ((nota1 < 0) || nota1 > 10))
                    Console.WriteLine("Digite a nota 1. [Entre 0-10]");

                Console.WriteLine("Digite a nota 2. [Entre 0-10]");
                double nota2;

                while ((!double.TryParse(Console.ReadLine(), out nota2)) || ((nota2 < 0) || nota2 > 10))
                    Console.WriteLine("Digite a nota 2. [Entre 0-10]");

                listaAlunos.Add(new Alunos(nome, nota1, nota2));
            }

            Console.WriteLine("======================================");
            Console.WriteLine("Alunos com média superior ou igual a 7");
            Console.WriteLine("======================================");

            if (listaAlunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno atingiu a média");
            }
            else
            {
                foreach (Alunos aluno in listaAlunos)
                {
                    if (aluno.Media >= 7)
                        Console.WriteLine("Nome: {0} - Média: {1}", aluno.Nome, aluno.Media);
                }
            }
            Console.WriteLine("======================================");
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
