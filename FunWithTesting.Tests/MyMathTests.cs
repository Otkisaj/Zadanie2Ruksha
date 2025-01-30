using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using FunWithUnitTesting;

namespace FunWithUnitTesting.Tests
{
    public class MyMathTests
    {
        private readonly MyMath _math = new MyMath();

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Assert.Equal(5, _math.Add(2, 3));
        }

        [Fact]
        public void Sub_ReturnsCorrectDifference()
        {
            Assert.Equal(1, _math.Sub(4, 3));
        }

        [Fact]
        public void Mul_ReturnsCorrectProduct()
        {
            Assert.Equal(12, _math.Mul(3, 4));
        }

        [Fact]
        public void Div_ReturnsCorrectQuotient()
        {
            Assert.Equal(2, _math.Div(6, 3));
        }

        [Fact]
        public void Div_ThrowsException_WhenDividingByZero()
        {
            Assert.Throws<System.DivideByZeroException>(() => _math.Div(6, 0));
        }
    }
}
