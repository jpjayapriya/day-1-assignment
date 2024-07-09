using NUnit.Framework;
using CalculatorLibrary;
using System;

namespace CalculatorLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            // Arrange
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoIntegers_ReturnsCorrectSum()
        {
            // Act
            int result = calculator.Add(5, 3);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_TwoIntegers_ReturnsCorrectDifference()
        {
            // Act
            int result = calculator.Subtract(5, 3);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiply_TwoIntegers_ReturnsCorrectProduct()
        {
            // Act
            int result = calculator.Multiply(5, 3);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Divide_TwoIntegers_ReturnsCorrectQuotient()
        {
            // Act
            int result = calculator.Divide(10, 2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsArgumentException()
        {
            // Act and Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        }
    }
}
