using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Contracts
{
    /// <summary>
    /// Число типа double гарантированно > 0
    /// </summary>
    public struct PositiveDouble : IComparable<PositiveDouble>
    {
        double _value;

        public PositiveDouble(double value)
        {
            _value = value > 0 ? value : throw new ArgumentException($"Positive value > 0 expected, { value } passed");
        }

        public PositiveDouble(decimal value) : this((double)value) { }
        public PositiveDouble(int value) : this((double)value) { }

        public int CompareTo(PositiveDouble other) => _value.CompareTo(other._value);

        public static implicit operator double(PositiveDouble value) => value._value;

        public static implicit operator decimal(PositiveDouble value) => (decimal)value._value;

        public static implicit operator int(PositiveDouble value) => (int)value._value;

        public static explicit operator PositiveDouble(double value) => new PositiveDouble(value);

        public static explicit operator PositiveDouble(decimal value) => new PositiveDouble(value);
        public static explicit operator PositiveDouble(int value) => new PositiveDouble(value);
    }
}
