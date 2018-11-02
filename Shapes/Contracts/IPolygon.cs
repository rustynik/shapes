using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Contracts
{
    /// <summary>
    /// Многоугольник (3- и более- угольник)
    /// </summary>
    public interface IPolygon : IArea, IPerimeter
    {
        /// <summary>
        /// Стороны
        /// </summary>
        IEnumerable<PositiveDouble> Sides { get; }
    }
}