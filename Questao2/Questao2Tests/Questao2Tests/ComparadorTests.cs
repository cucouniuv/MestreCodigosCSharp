using Questao2;
using System.Collections.Generic;
using Xunit;

namespace Questao2Tests
{
    public class ComparadorTests
    {
        [Fact]
        public void VerificarFuncionarioComMaiorSalario()
        {
            // Arrange
            double valorEsperado = 8450.00;

            List<Funcionario> listaFuncionario = new List<Funcionario>
            {
                new Funcionario("Luis", 1500.00),
                new Funcionario("Maria", 5500.50),
                new Funcionario("Reginaldo", 8450.00),
                new Funcionario("Tony", 0.00),
                new Funcionario("Carlos", 1.00)
            };

            // Act
            ComparadorFuncionario.DefinirFuncionarioComMaiorEMenorSalarioDeUmaLista(listaFuncionario,
                out Funcionario funcionarioMaiorSalario, out _);

            // Assert
            Assert.Equal(valorEsperado, funcionarioMaiorSalario.Salario);
        }

        [Fact]
        public void VerificarFuncionarioComMenorSalario()
        {
            // Arrange
            double valorEsperado = 0.00;

            List<Funcionario> listaFuncionario = new List<Funcionario>
            {
                new Funcionario("Luis", 1500.00),
                new Funcionario("Maria", 5500.50),
                new Funcionario("Reginaldo", 8450.00),
                new Funcionario("Tony", 0.00),
                new Funcionario("Carlos", 0.01)
            };

            // Act
            ComparadorFuncionario.DefinirFuncionarioComMaiorEMenorSalarioDeUmaLista(listaFuncionario,
                out _, out Funcionario funcionarioMenorSalario);

            // Assert
            Assert.Equal(valorEsperado, funcionarioMenorSalario.Salario);
        }
    }
}
