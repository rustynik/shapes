using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Contracts
{
    public interface IPolygon : IArea, IPerimeter
    {
        IEnumerable<double> Sides { get; }
    }
}
