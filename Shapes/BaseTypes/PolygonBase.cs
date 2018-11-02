using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Shapes.BaseTypes
{
    public abstract class PolygonBase : IPolygon
    {
        public PolygonBase(params PositiveDouble[] sides)
        {
            Sides = sides;
        }

        public IEnumerable<PositiveDouble> Sides { get; }

        public PositiveDouble GetPerimeter()
        => (PositiveDouble)Sides.Select(x => (double)x).Sum();

        public abstract PositiveDouble GetArea();
    }
}
