using ProvaTecnica.Calculos;
using Xunit;

namespace ProvaTecnica.Tests
{
    public class CalculoJurosTest
    {
        [Theory]
        [InlineData(100, 5, 105.10)]
        public void CalculoDeJuros_100_5(double valorinicial, int meses, double resultado)
        {
            CalculosJuros calc = new CalculosJuros();
            double valor = calc.CalcurarJuros(valorinicial, meses);

            Assert.Equal(resultado, valor);
        }
    }
}