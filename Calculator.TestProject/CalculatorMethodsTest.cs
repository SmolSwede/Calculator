using System;
using Xunit;

namespace Calculator.TestProject
{
    public class CalculatorMethodsTest
    {
        Methods methods = new Methods();

        private double[] numArray = { 1, 1 };

        [Fact]
        public void AdditionTest()
        {
            double num1 = 1;
            double num2 = 1;
            double expectedSum = 2;

            double sum = methods.Addition(num1, num2);

            Assert.Equal(expectedSum, sum, 0);
        }

        [Fact]
        public void ArrayAdditionTest()
        {
            double expectedSum = 2;

            double sum = methods.Addition(numArray);

            Assert.Equal(expectedSum, sum, 0);
        }

        [Fact]
        public void SuptractionTest()
        {
            double num1 = 1;
            double num2 = 1;
            double expectedSum = 0;

            double sum = methods.Suptraction(num1, num2);

            Assert.Equal(expectedSum, sum, 0);
        }

        [Fact]
        public void ArraySuptractionTest()
        {
            double expectedSum = 0;

            double sum = methods.Suptraction(numArray); 

            Assert.Equal(expectedSum, sum, 0);
        }

        [Fact]
        public void MultiplicationTest()
        {
            double num1 = 4;
            double num2 = 2;
            double expectedSum = 8;

            double sum = methods.Multiplication(num1, num2);

            Assert.Equal(expectedSum, sum, 0);
        }

        [Fact]
        public void DivisionTest()
        {
            double num1 = 1;
            double num2 = 4;
            double expectedSum = 0.25;

            double sum = methods.Division(num1, num2);

            Assert.Equal(expectedSum, sum, 2);
        }

        [Fact]
        public void DivisionByZeroTest()
        {
            double num1 = 2;
            double num2 = 0;
            double expectedSum = 0;

            double sum = methods.Division(num1, num2);

            Assert.Equal(expectedSum, sum, 0);
        }
    }
}
