using Xunit;
using Calculadora.Services;
using System;

namespace CalculadoraTestes
{
    public class CalculadoraTests
    {
        private readonly CalculadoraImpl _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new CalculadoraImpl();
        }

        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(-1, -1, -2)]
        [InlineData(0, 0, 0)]
        public void DeveSomar(int num1, int num2, int esperado)
        {
            // Act
            int resultado = _calculadora.Somar(num1, num2);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-1, -1, 0)]
        [InlineData(0, 0, 0)]
        public void DeveSubtrair(int num1, int num2, int esperado)
        {
            // Act
            int resultado = _calculadora.Subtrair(num1, num2);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        [InlineData(-1, -1, 1)]
        [InlineData(0, 5, 0)]
        public void DeveMultiplicar(int num1, int num2, int esperado)
        {
            // Act
            int resultado = _calculadora.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        [InlineData(-8, -2, 4)]
        public void DeveDividir(int num1, int num2, double esperado)
        {
            // Act
            double resultado = _calculadora.Dividir(num1, num2);

            // Assert
            Assert.Equal(esperado, resultado, precision: 2);
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(0, 0)]
        public void DeveLancarExcecaoDivisaoPorZero(int num1, int num2)
        {
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(num1, num2));
        }
    }
}
