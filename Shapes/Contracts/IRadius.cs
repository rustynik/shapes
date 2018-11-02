using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Contracts
{
    /// <summary>
    /// Фигура, имеющая радиус
    /// </summary>
    public interface IRadius
    {
        /// <summary>
        /// Радиус 
        /// </summary>
        PositiveDouble Radius { get; set; }
    }
}
