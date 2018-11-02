using Shapes.BuiltIn;
using System;
using System.Linq;
using Xunit;

namespace Shapes.Tests
{
    public class TriangleShould
    {
        [Fact]
        public void BeConstructed()
        {
            new Triangle(8, 15, 17);
            new Triangle(new double[] { 8, 15, 17 });
        }

        [Fact]
        public void HaveThreeSides()
        {
            Assert.Equal(3, new Triangle(8, 15, 17).Sides.Count());
        }

        [Fact]
        
        public void ThrowOnWrongNumberOfSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(new double[] { 8, 15 }));
        }

        [Fact]
        public void ThrowOnZeroSideValue()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(new double[] { 8, 15, 0 }));
        }

        [Fact]
        public void ThrowOnNegativeSideValue()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(new double[] { 8, 15, 0 }));
        }

        [Fact]
        public void CalculateArea()
        {
            Assert.Equal(60, new Triangle(8, 15, 17).GetArea());
        }

        [Fact]
        public void BeRightAngled()
        {
            Assert.True(new Triangle(8, 15, 17).IsRightAngled());
        }

        [Fact]
        public void NotBeRightAngled()
        {
            Assert.False(new Triangle(8, 13, 17).IsRightAngled());
        }
    }
}
