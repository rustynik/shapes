using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Contracts
{
    /// <summary>
    /// Является ли фигура прямоугольной (напр., треугольник)
    /// </summary>
    public interface IIsRightAngled
    {
        /// <summary>
        /// Является ли фигура прямоугольной 
        /// </summary>
        /// <returns></returns>
        bool IsRightAngled();
    }
}
