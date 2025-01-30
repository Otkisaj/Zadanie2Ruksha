using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting.Tests
{
    public class StringServiceTests
    {
        [Fact]
        public void GetLength_ReturnsCorrectLength()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.GetLength("Hello");

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void GetColor_ReturnsCorrectColorName()
        {
            // Arrange
            var service = new StringService();

            // Act & Assert
            Assert.Equal("Czarny", service.GetColor(Colors.Black));
            Assert.Equal("Czerwony", service.GetColor(Colors.Red));
            Assert.Equal("Zolty", service.GetColor(Colors.Yellow));
            Assert.Equal("Zielony", service.GetColor(Colors.Green));
            Assert.Equal(string.Empty, service.GetColor(Colors.None));
        }

        [Fact]
        public void DoSomething_ReturnsUpperCaseStringWithPadding()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.DoSomething("test");

            // Assert
            Assert.Equal("TEST----------------", result);
        }
    }
}
