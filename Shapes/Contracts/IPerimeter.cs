using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Contracts
{
    /// <summary>
    /// Объект, имеющий периметр
    /// </summary>
    public interface IPerimeter
    {
        /// <summary>
        /// Получить периметр
        /// </summary>
        /// <returns></returns>
        PositiveDouble GetPerimeter();
    }
}
