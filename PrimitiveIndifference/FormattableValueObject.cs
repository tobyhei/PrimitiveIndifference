using System;

namespace PrimitiveIndifference
{
    public class FormattableValueObject<T> : ValueObject<T>
        where T : IFormattable, IComparable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public FormattableValueObject(T value) : base(value)
        {
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return Value.ToString(format, formatProvider);
        }
    }
}
