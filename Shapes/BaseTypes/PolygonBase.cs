using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes.BaseTypes
{
    public abstract class PolygonBase : IPolygon
    {
        public PolygonBase(IEnumerable<double> sides)
        {
            Sides = sides.All(x => x > 0) ? sides : throw new ArgumentException("All sides should be postive numbers greater than 0");
            Perimeter = Sides.Sum();
        }

        public IEnumerable<double> Sides { get; }

        public double Perimeter { get; }

        public abstract double Area { get; }
    }
}
