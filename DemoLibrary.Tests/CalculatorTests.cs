using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            // General Layout of a Test
            // 1. Arrange - Where we arrange our values and get things setup to run out test
            // 2. Act - Do actual action that we are testing
            // 3. Assert - This is what i expect compare actual value and expected value

            // Arrange
            double expected = 5;

            // Act
            double actual = Calculator.Add(2, 3);

            // Assert
            Assert.Equal(expected, actual);

        }

    }
}
