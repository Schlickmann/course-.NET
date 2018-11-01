using Packt.CS7;
using Xunit;

namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            // arrange : This part will declare and instantiate variables for input and output
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();
            // act: This part will execute the unit that you are testing
            double actual = calc.Add(a, b);
            // assert: This part will make one or more assertions about the output
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdding2And3()
        {
            // arrange
            double a = 2;
            double b = 3;
            double expected = 5;
            var calc = new Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }
    }
}
