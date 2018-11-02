using Shapes.BuiltIn;
using Shapes.Contracts;
using System;
using System.Linq;
using Xunit;

namespace Shapes.Tests
{
    public class CircleShould
    {
        [Fact]
        public void BeConstructed()
        {
            new Circle(8);
        }


        [Fact]
        public void ThrowOnZeroRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void ThrowOnNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void CalculateAreaCorrectly()
        {
            Assert.Equal(Math.PI * 4, new Circle(2).GetArea());
        }
    }
}
