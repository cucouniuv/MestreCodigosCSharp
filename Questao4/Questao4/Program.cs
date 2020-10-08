using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine(String.Empty);
            Console.WriteLine("Digite a quantidade de notas exigidas");
            int quantidadeNotas;
            while (!int.TryParse(Console.ReadLine(), out quantidadeNotas))
                Console.WriteLine("Valor inválido. Digite a quantidade de notas exigidas");

            double[] notasDigitadas = new double[quantidadeNotas];
            List<Aluno> listaAlunos = new List<Aluno>();
            
            while (true)
            {
                Console.WriteLine(String.Empty);
                Console.WriteLine("Digite o nome do aluno ou digite exatamente Parar");
                string nome;
                
                while ((nome = Console.ReadLine()).Length == 0)
                    Console.WriteLine("Valor inválido. Digite o nome do aluno ou digite exatamente Parar");

                if (nome == "Parar")
                    break;

                double nota = 0;
                for (int i = 0; i < quantidadeNotas; i++)
                {
                    Console.WriteLine(String.Empty);
                    Console.WriteLine("Digite a nota " + (i + 1) + ". [Entre 0-10]");

                    while ((!double.TryParse(Console.ReadLine(), out nota)) || ((nota < 0) || nota > 10))
                    {
                        Console.WriteLine(String.Empty);
                        Console.WriteLine("Valor inválido. Digite a nota " + (i + 1) + ". [Entre 0-10]");
                    }

                    notasDigitadas[i] = nota;
                }

                listaAlunos.Add(new Aluno(nome, notasDigitadas));
            }

            if (listaAlunos.Count == 0)
            {
                Console.WriteLine(String.Empty);
                Console.WriteLine("Nenhum aluno informado.");
                return;
            }

            if (!listaAlunos.Any(aluno => aluno.Media > 7))
            {
                Console.WriteLine(String.Empty);
                Console.WriteLine("Nenhum aluno informado possui média superior a 7");
                return;
            }

            Console.WriteLine(String.Empty);
            Console.WriteLine("======================================");
            Console.WriteLine("Alunos que atingiram a média superior a 7");
            Console.WriteLine("======================================");

            foreach (Aluno aluno in listaAlunos)
            {
                if (aluno.Media > 7)
                    Console.WriteLine("Nome: {0} - Média: {1}", aluno.Nome, aluno.Media);
            }

            Console.WriteLine("======================================");
        }
    }
}
