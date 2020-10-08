using System;

namespace Questao2POO
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public decimal Altura { get; set; }

        public string ImprimirDados()
        {
            return string.Format("Nome: {0}, Nascimento: {1}, Altura: {2}, Idade: {3}",
                Nome, DataNascimento, Altura, RetornarIdade(DateTime.Now));
        }

        public int RetornarIdade(DateTime dataAtual)
        {
            int anosDiferenca = dataAtual.Year - DataNascimento.Year;

            DateTime dataAtualSubtraida = dataAtual.AddYears(-anosDiferenca);

            if (DataNascimento.Date > dataAtualSubtraida.Date)
                anosDiferenca--;

            return (anosDiferenca);
        }

    }
}
