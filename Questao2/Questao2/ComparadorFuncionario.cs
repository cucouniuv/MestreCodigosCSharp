using System.Collections.Generic;

namespace Questao2
{
    public class ComparadorFuncionario
    {
        public static void DefinirFuncionarioComMaiorEMenorSalarioDeUmaLista(List<Funcionario> lista,
            out Funcionario funcionarioMaiorSalario, out Funcionario funcionarioMenorSalario)
        {
            funcionarioMenorSalario = new Funcionario(lista[0].Nome, lista[0].Salario);
            funcionarioMaiorSalario = new Funcionario(lista[0].Nome, lista[0].Salario);

            int i;
            for (i = 0; i < lista.Count; i++)
            {
                if (lista[i].Salario > funcionarioMaiorSalario.Salario)
                    funcionarioMaiorSalario = lista[i];

                if (lista[i].Salario < funcionarioMenorSalario.Salario)
                    funcionarioMenorSalario = lista[i];
            }
        }
    }
}
