using XUnit_Acceptanstesting_Labb7;

namespace XUnit_Acceptanstesting_Labb7_XUnitTesting
{
    public class Calculator_Tests
    {
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(50,27,77)]
        [InlineData(5.5,5.5,11)]
        [InlineData(2.6,10,12.6)]
        [InlineData(500000,500000,1000000)]
        [InlineData(-7,-7,-14)]
        public void AdditionTestValue(decimal value1,decimal value2,decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            calculator.Addition(value1,value2);

            //Assert
            Assert.Equal(expected,calculator.total);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(2, 2, 1)]
        [InlineData(5, 2, 2.5)]
        [InlineData(-100, -10, 10)]
        [InlineData(10, 100, 0.1)]
        public void DivisionTestValue(decimal value1, decimal value2, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            calculator.Division(value1, value2);

            //Arrange
            Assert.Equal(expected,calculator.total);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(100, 500, -400)]
        [InlineData(-100, -200, 100)]
        [InlineData(10000, 9999, 1)]
        [InlineData(7.3, 5, 2.3)]
        public void SubtractionTestValue(decimal value1, decimal value2, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            calculator.Subtraction(value1, value2);

            //Assert
            Assert.Equal(expected, calculator.total);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 500, 5000)]
        [InlineData(-10, -200, 2000)]
        [InlineData(-1, 5.6, -5.6)]
        [InlineData(7.3, 2, 14.6)]
        public void MultiplicationTestValue(decimal value1, decimal value2, decimal expected)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            calculator.Multiplication(value1, value2);

            //Assert
            Assert.Equal(expected, calculator.total);
        }
    }
}