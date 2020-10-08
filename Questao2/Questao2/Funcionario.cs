using System.Collections.Generic;

namespace Questao2
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public static void DefinirFuncionarioComMaiorEMenorSalarioDeUmaLista(List<Funcionario> lista, 
            out Funcionario funcionarioMaiorSalario, out Funcionario funcionarioMenorSalario)
        {
            funcionarioMenorSalario = new Funcionario(lista[0].Nome, lista[0].Salario);
            funcionarioMaiorSalario = new Funcionario(lista[0].Nome, lista[0].Salario);

            int i;
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i].Salario > funcionarioMaiorSalario.Salario)
                {
                    funcionarioMaiorSalario.Salario = lista[i].Salario;
                    funcionarioMaiorSalario.Nome = lista[i].Nome;
                }

                if (lista[i].Salario < funcionarioMenorSalario.Salario)
                {
                    funcionarioMenorSalario.Salario = lista[i].Salario;
                    funcionarioMenorSalario.Nome = lista[i].Nome;
                }
            }
        }
    }
}
