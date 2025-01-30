using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace FunWithUnitTesting.Tests
{
    public class ColorTests
    {
        [Fact]
        public void GetColor_ReturnsCzarny_ForBlack()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.GetColor(Colors.Black);

            // Assert
            Assert.Equal("Czarny", result);
        }

        [Fact]
        public void GetColor_ReturnsCzerwony_ForRed()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.GetColor(Colors.Red);

            // Assert
            Assert.Equal("Czerwony", result);
        }

        [Fact]
        public void GetColor_ReturnsZolty_ForYellow()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.GetColor(Colors.Yellow);

            // Assert
            Assert.Equal("Zolty", result);
        }

        [Fact]
        public void GetColor_ReturnsZielony_ForGreen()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.GetColor(Colors.Green);

            // Assert
            Assert.Equal("Zielony", result);
        }

        [Fact]
        public void GetColor_ReturnsEmptyString_ForNone()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.GetColor(Colors.None);

            // Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GetColor_ReturnsNieWiem_ForUnknownValue()
        {
            // Arrange
            var service = new StringService();

            // Act
            var result = service.GetColor((Colors)999); // Неизвестное значение

            // Assert
            Assert.Equal("nie wiem", result);
        }
    }
}
