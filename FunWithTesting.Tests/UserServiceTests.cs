using FunWithUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTesting.Tests
{
    public class UserServiceTests
    {
        [Fact]
        public void RegistryUser_ReturnsError_WhenUserIsNull()
        {
            // Arrange
            var userRepo = new UserRepoFake();
            var passwordService = new PasswordServiceFake();
            var service = new UserService(userRepo, passwordService);

            // Act
            var result = service.RegistryUser(null);

            // Assert
            Assert.Equal("User must be not null", result);
        }

        [Fact]
        public void RegistryUser_ReturnsError_WhenPasswordIsInvalid()
        {
            // Arrange
            var userRepo = new UserRepoFake();
            var passwordService = new PasswordServiceFake();
            var service = new UserService(userRepo, passwordService);
            var user = new UserService.User { Email = "test@example.com", Password = "123" };

            // Act
            var result = service.RegistryUser(user);

            // Assert
            Assert.Equal("haslo ma mniej za 8 symbolow", result);
        }

        [Fact]
        public void RegistryUser_ReturnsError_WhenEmailIsTaken()
        {
            // Arrange
            var existingUser = new UserService.User { Email = "test@example.com", Password = "password123" };
            var userRepo = new UserRepoFake(existingUser); // Заглушка возвращает существующего пользователя
            var passwordService = new PasswordServiceFake();
            var service = new UserService(userRepo, passwordService);
            var user = new UserService.User { Email = "test@example.com", Password = "password123" };

            // Act
            var result = service.RegistryUser(user);

            // Assert
            Assert.Equal("Email jest zajety", result);
        }

        [Fact]
        public void RegistryUser_ReturnsSuccess_WhenUserIsValid()
        {
            // Arrange
            var userRepo = new UserRepoFake(); // Заглушка не возвращает пользователя (email свободен)
            var passwordService = new PasswordServiceFake();
            var service = new UserService(userRepo, passwordService);
            var user = new UserService.User { Email = "test@example.com", Password = "password123" };

            // Act
            var result = service.RegistryUser(user);

            // Assert
            Assert.Equal("OK", result);
        }


    }
    
}
