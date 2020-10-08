using System;
using Xunit;
using Questao2POO;

namespace Questao2POOTests
{
    public class PessoaTests
    {
        public static readonly object[][] CorrectData =
        {
            new object[] { "Joao", new DateTime(1990, 3, 1), 1.80, "Nome: Joao, Nascimento: 01/03/1990 00:00:00, Altura: 1,8"},
            new object[] { "Maria", new DateTime(1992, 2, 1), 1.65, "Nome: Maria, Nascimento: 01/02/1992 00:00:00, Altura: 1,65"}
        };

        [Theory, MemberData(nameof(CorrectData))]
        public void ImprimirDadosAposDefinirNomeIdadeEAlturaDePessoa
            (string nome, DateTime dataNascimento, decimal altura, string valorEsperado)
        {
            // Arrange
            Pessoa pessoa = new Pessoa
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Altura = altura
            };

            // Act
            string valorCalculado = pessoa.ImprimirDados();

            // Assert
            Assert.Contains(valorEsperado, valorCalculado);
        }

        public static readonly object[][] DatasNascimento =
        {
            new object[] {new DateTime(1990, 3, 1), new DateTime(2020, 3, 1), 30},
            new object[] {new DateTime(1990, 3, 1), new DateTime(2020, 2, 27), 29},
            new object[] {new DateTime(1992, 2, 1), new DateTime(2020, 10, 8), 28}
        };
        [Theory, MemberData(nameof(DatasNascimento))]
        public void CalcularIdade(DateTime dataNascimento, DateTime dataAtual, int idadeEsperada)
        {
            // Arrange
            Pessoa pessoa = new Pessoa
            {
                DataNascimento = dataNascimento
            };

            // Act
            int idadeCalculada = pessoa.RetornarIdade(dataAtual);

            // Assert
            Assert.Equal(idadeEsperada, idadeCalculada);
        }
    }
}
