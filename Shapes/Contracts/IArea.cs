using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Contracts
{
    /// <summary>
    /// Объект, имеющий площадь
    /// </summary>
    public interface IArea
    {
        /// <summary>
        /// Получить площадь объекта
        /// </summary>
        /// <returns></returns>
        PositiveDouble GetArea();
    }

    
}
