using CalculatorTest.BLL.Services;

namespace CalculatorTest.Test
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void CheckIf_AddMethodReturnsCorrectResult()
        {
            //Arrange
            var start = 4;
            var amount = 20;

            SimpleCalculatorService calculatorService = new SimpleCalculatorService();

            var expectedValue = 24;

            //Act
            var result = calculatorService.Add(start, amount);

            //Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void CheckIf_SubtractMethodReturnsCorrectResult()
        {
            //Arrange
            var start = 40;
            var amount = 20;

            SimpleCalculatorService calculatorService = new SimpleCalculatorService();

            var expectedValue = 20;

            //Act
            var result = calculatorService.Subtract(start, amount);

            //Assert
            Assert.Equal(expectedValue, result);
        }
    }
}