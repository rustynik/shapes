using Shapes.BaseTypes;
using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes.BuiltIn
{
    public class Triangle : PolygonBase, ITriangle
    {
        public Triangle(params double[] sides) : base(sides.Length == 3 ? sides : throw new ArgumentException("Number of sides should be exactly 3 in a triangles"))
        {
            Area = GetArea();
            IsRightAngled = IsTriangleRightAngled();
        }

        public override double Area { get; } 

        public bool IsRightAngled { get; }

        private double GetArea()
        {
            var halfPerimeter = Perimeter / 2;
            return Math.Sqrt(Sides.Aggregate(halfPerimeter, (acc, side) => acc * (halfPerimeter - side)));
        } 

        private bool IsTriangleRightAngled()
        {
            var longest = Sides.Max();
            return Math.Pow(longest, 2) - Sides.Where(x => x != longest).Sum(x => Math.Pow(x, 2)) < Math.Sqrt(double.Epsilon);
        }
    }
}
