using System;
using Xunit;
using Questao3POO;

namespace Questao3POOTests
{
    public class ContaBancariaTests
    {
        // Material de apoio: http://www.macoratti.net/19/09/cshp_unitest1.htm
        // Para testes sem parâmetros deve-se usar [Fact]
        // Para testes como parâmetros utiliza-se o [Theory]
        [Fact]
        [Trait("Tipo", "Fact")]
        public void DepositarValor500EmContaCorrente()
        {
            // Arrange
            ContaCorrente contaCorrente = new ContaCorrente();
            double valorEsperado = 500;

            // Act
            contaCorrente.Depositar(500);

            // Assert
            Assert.Equal(valorEsperado, contaCorrente.Saldo);
        }

        [Theory]
        [Trait("Tipo", "Theory")]
        [InlineData(600, 600)]
        [InlineData(27.50, 27.50)]
        public void DepositarValorEmContaCorrenteEConferir(double valorDeposito, double valorEsperado)
        {
            // Arrange
            ContaCorrente contaCorrente = new ContaCorrente();

            // Act
            contaCorrente.Depositar(valorDeposito);

            // Assert
            Assert.Equal(valorEsperado, contaCorrente.Saldo);
        }

        [Theory]
        [Trait("Tipo", "Theory")] // Utilizado para fins de organização
        [InlineData(600, 500, 100)]
        [InlineData(27.50, 10.25, 17.25)]
        public void DepositarValorEmSeguidaSacarEConferir(double valorDeposito, double valorSaque, double valorEsperado)
        {
            // Arrange
            ContaCorrente contaCorrente = new ContaCorrente();

            // Act
            contaCorrente.Depositar(valorDeposito);
            contaCorrente.Sacar(valorSaque);

            // Assert
            Assert.Equal(valorEsperado, contaCorrente.Saldo);
        }

        [Theory]
        [Trait("Tipo", "Theory")] // Utilizado para fins de organização
        [InlineData(0, 600, 500, 100)]
        [InlineData(0, 27.50, 10.25, 17.25)]
        [InlineData(300, 600, 600, 0)]
        [InlineData(300, 600, 700, -100)]
        public void DepositarValorEmContaEspecialEEmSeguidaSacarEConferir
            (double valorLimite, double valorDeposito, double valorSaque, double valorEsperado)
        {
            // Arrange
            ContaEspecial contaEspecial = new ContaEspecial
            {
                Limite = valorLimite
            };

            // Act
            contaEspecial.Depositar(valorDeposito);
            contaEspecial.Sacar(valorSaque);

            // Assert
            Assert.Equal(valorEsperado, contaEspecial.Saldo);
        }

        [Theory]
        [Trait("Tipo", "Theory")]
        [InlineData(300, 600, 1000)]
        public void DepositarValorEmContaEspecialEEmSeguidaSacarParaDispararExcecao
            (double valorLimite, double valorDeposito, double valorSaque)
        {
            // Arrange
            ContaEspecial contaEspecial = new ContaEspecial
            {
                Limite = valorLimite
            };

            // Act
            contaEspecial.Depositar(valorDeposito);
            void act() => contaEspecial.Sacar(valorSaque);

            // Assert
            var exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Conta Especial 0 possui saldo insuficiente para realizar este saque.", exception.Message);
        }
    }
}
