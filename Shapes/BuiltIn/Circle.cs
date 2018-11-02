using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.BuiltIn
{
    
    public struct Circle : IArea, IRadius
    {
        public Circle(double radius) : this((PositiveDouble)radius)
        { }

        public Circle(PositiveDouble radius)
        {
            Radius = radius;
        }

        public PositiveDouble GetArea() => (PositiveDouble)(Math.PI * Math.Pow(Radius, 2));

        public PositiveDouble Radius { get; set; }
    }
}
