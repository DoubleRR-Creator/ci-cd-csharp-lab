using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorSubtractTests
    {
        [Fact]
        public void Subtract_TwoPositiveNumbers_ReturnsDifference()
        {
            Calculator calc = new Calculator();
            Assert.Equal(2, calc.Subtract(5, 3));
        }

        [Fact]
        public void Subtract_ResultIsNegative_ReturnsNegative()
        {
            Calculator calc = new Calculator();
            Assert.Equal(-2, calc.Subtract(3, 5));
        }

        [Fact]
        public void Subtract_TwoNegativeNumbers_ReturnsDifference()
        {
            Calculator calc = new Calculator();
            Assert.Equal(2, calc.Subtract(-3, -5));
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(-5, 5, -10)]
        [InlineData(100, 50, 50)]
        [InlineData(0, 5, -5)]
        public void Subtract_MultipleValues_ReturnsExpected(int a, int b, int expected)
        {
            Calculator calc = new Calculator();
            Assert.Equal(expected, calc.Subtract(a, b));
        }
    }
}