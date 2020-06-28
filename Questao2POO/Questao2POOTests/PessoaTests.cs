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
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.DataNascimento = dataNascimento;
            pessoa.Altura = altura;

            // Act
            string valorCalculado = pessoa.ImprimirDados();

            // Assert
            Assert.Contains(valorEsperado, valorCalculado);
        }
    }
}
