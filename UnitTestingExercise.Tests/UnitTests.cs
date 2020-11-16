using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(8, 7, 12, 27)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var testMethods = new UnitTestMethods();

            //Act
            var actual = testMethods.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7, 1, 6)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var testMethods = new UnitTestMethods();

            //Act
            var actual = testMethods.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 6, 36)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var testMethods = new UnitTestMethods();

            //Act
            var actual = testMethods.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 8, 2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var testMethods = new UnitTestMethods();

            //Act
            var actual = testMethods.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NameExists()
        {
            //Arrange
            var testMethods = new UnitTestMethods();
            var name = "Ben";

            //Act
            var actual = testMethods.NameExists(name);

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var testMethods = new UnitTestMethods();

            //Act

            //Assert
        }
    }
}
