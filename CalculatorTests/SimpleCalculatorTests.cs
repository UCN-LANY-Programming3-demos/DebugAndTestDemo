using Xunit;
using DebugAndTestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugAndTestDemo.Tests
{
    public class SimpleCalculatorTests
    {
        [Fact()]
        public void AddSuccessTest()
        {
            // Arrange
            double a = 2;
            double b = 2;
            double expectedResult = 4;

            // Act
            double result = SimpleCalculator.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact()]
        public void AddAnotherSuccessTest()
        {
            // Arrange
            double a = 2;
            double b = 3;
            double expectedResult = 5;

            // Act
            double result = SimpleCalculator.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, result);

        }
    }
}