using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.BuiltIn
{
    public interface IRadius
    {
        double Radius { get; }
    }
    public struct Circle : IArea, IRadius
    {
        public Circle(double radius)
        {
            Radius = radius > 0 ? radius : throw new ArgumentException("radius should be positive");
            Area = Math.PI * Math.Pow(Radius, 2);
        }
        
        public double Area { get; }

        public double Radius { get; }
    }
}
