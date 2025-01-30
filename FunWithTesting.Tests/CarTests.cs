using Xunit;
using FunWithUnitTesting;


namespace FunWithUnitTesting.Tests
{
    public class CarTests
    {
        [Fact]
        public void Constructor_SetsCurrentSpeed_WhenSpeedIsBelowMax()
        {
            // Arrange
            var car = new Car(100);

            // Assert
            Assert.Equal(100, car.CurrentSpeed);
        }

        [Fact]
        public void Constructor_SetsMaxSpeed_WhenSpeedExceedsMax()
        {
            // Arrange
            var car = new Car(250);

        }

    }
}
