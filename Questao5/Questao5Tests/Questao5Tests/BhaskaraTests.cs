using Xunit;
using Questao5;

namespace Questao5Tests
{
    public class BhaskaraTests
    {
        [Theory]
        [InlineData(3, -15, 12, 4, 1)]
        [InlineData(9, -24, 16, 1.33, 1.33)]
        public void CalcularValorDeX1EDeX2DaBhaskara(int a, int b, int c, double x1Esperado, double x2Esperado)
        {
            Bhaskara bhaskara = new Bhaskara(a, b, c);

            double x1Calculado = bhaskara.CalcularValorX1();
            double x2Calculado = bhaskara.CalcularValorX2();

            Assert.Equal(x1Esperado, x1Calculado);
            Assert.Equal(x2Esperado, x2Calculado);
        }
    }
}

