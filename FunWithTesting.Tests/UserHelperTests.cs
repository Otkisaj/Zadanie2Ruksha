using FunWithUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FunWithUnitTesting.Tests
{
    public class UserHelperTests
    {
        [Fact]
        public void UserReadNumberBetter_ReturnsTrue_WhenInputIsNumber()
        {
            // Arrange
            var console = new MockConsole("123"); // Заглушка для консоли
            var helper = new UserHelper(console);

            // Act
            var result = helper.UserReadNumberBetter("123");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void UserReadNumberBetter_ReturnsFalse_WhenInputIsNotNumber()
        {
            // Arrange
            var console = new MockConsole("abc"); // Заглушка для консоли
            var helper = new UserHelper(console);

            // Act
            var result = helper.UserReadNumberBetter("abc");

            // Assert
            Assert.False(result);
        }
    }

    // Реализация мок-объекта для IConsole
    public class MockConsole : IConsole
    {
        private readonly string _input;

        public MockConsole(string input)
        {
            _input = input;
        }

        public string ReadLine()
        {
            return _input;
        }
    }
}