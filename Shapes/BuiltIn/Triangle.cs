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
        public Triangle(params double[] sides) : this(Array.ConvertAll(sides, x => (PositiveDouble)x)) { }
        public Triangle(params PositiveDouble[] sides) : base(sides.Length == 3 ? sides : throw new ArgumentException("Number of sides should be exactly 3 in a triangles"))
        { }
        
        public override PositiveDouble GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return (PositiveDouble)(Math.Sqrt(Sides.Aggregate(halfPerimeter, (acc, side) => acc * (halfPerimeter - side))));
        } 

        public bool IsRightAngled()
        {
            var longest = Sides.Max();
            return Math.Pow(longest, 2) == Sides.Where(x => x != longest).Sum(x => Math.Pow(x, 2));
        }
    }
}
