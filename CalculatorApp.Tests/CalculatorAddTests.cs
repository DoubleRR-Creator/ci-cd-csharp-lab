using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorAddTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Calculator calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }

        [Fact]
        public void Add_NegativeAndPositive_ReturnsZero()
        {
            Calculator calc = new Calculator();
            Assert.Equal(0, calc.Add(-5, 5));
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            Calculator calc = new Calculator();
            Assert.Equal(-8, calc.Add(-3, -5));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(10, 20, 30)]
        [InlineData(-1, -1, -2)]
        [InlineData(-10, 10, 0)]
        [InlineData(100, 200, 300)]
        [InlineData(-5, -5, -10)]
        public void Add_MultipleValues_ReturnsExpected(int a, int b, int expected)
        {
            Calculator calc = new Calculator();
            Assert.Equal(expected, calc.Add(a, b));
        }
    }
}