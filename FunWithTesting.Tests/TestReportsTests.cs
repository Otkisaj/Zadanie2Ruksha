using FunWithUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTesting.Tests
{
    namespace FunWithUnitTesting.Tests
    {
        public class TestRaportTests
        {
            [Fact]
            public void Raport_SendsEmail_WhenStateIsSuccess()
            {
                // Arrange
                var mockSender = new MockSender();
                var raport = new TestRaport(mockSender);

                // Act
                raport.Raport(State.Success);

                // Assert
                Assert.True(mockSender.EmailSent);
                Assert.False(mockSender.SmsSent);
            }

            [Fact]
            public void Raport_SendsSms_WhenStateIsFailed()
            {
                // Arrange
                var mockSender = new MockSender();
                var raport = new TestRaport(mockSender);

                // Act
                raport.Raport(State.Faild);

                // Assert
                Assert.True(mockSender.SmsSent);
                Assert.False(mockSender.EmailSent);
            }

            [Fact]
            public void Raport_DoesNothing_WhenStateIsWaiting()
            {
                // Arrange
                var mockSender = new MockSender();
                var raport = new TestRaport(mockSender);

                // Act
                raport.Raport(State.Waiting);

                // Assert
                Assert.False(mockSender.EmailSent);
                Assert.False(mockSender.SmsSent);
            }
        }

        // Реализация мок-объекта для ISender
        public class MockSender : ISender
        {
            public bool EmailSent { get; private set; }
            public bool SmsSent { get; private set; }

            public void SendEmail(string message)
            {
                EmailSent = true;
            }

            public void SendSms(string message)
            {
                SmsSent = true;
            }
        }
    }
}
