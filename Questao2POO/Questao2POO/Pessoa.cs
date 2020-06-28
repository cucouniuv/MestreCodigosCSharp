using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2POO
{
    public class Pessoa
    {
        private string _nome;
        private DateTime _dataNascimento;
        private decimal _altura;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        public decimal Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public string ImprimirDados()
        {
            string dados;

            dados = "Nome: " + _nome;
            dados += ", Nascimento: " + _dataNascimento;
            dados += ", Altura: " + _altura;
            dados += ", Idade: " + RetornarIdade();

            return dados;
        }

        public int RetornarIdade()
        {
            DateTime dataAtual = DateTime.Now;

            int anosDiferenca = dataAtual.Year - _dataNascimento.Year;

            DateTime dataAtualSubtraida = dataAtual.AddYears(-anosDiferenca);

            if (_dataNascimento.Date > dataAtualSubtraida.Date)
                anosDiferenca--;

            return (anosDiferenca);
        }

    }
}
