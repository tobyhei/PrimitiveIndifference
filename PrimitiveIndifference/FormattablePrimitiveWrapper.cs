using System;

namespace PrimitiveIndifference
{
    public class FormattablePrimitiveWrapper<T> : PrimitiveWrapper<T>
        where T : IFormattable, IComparable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public FormattablePrimitiveWrapper(T value) : base(value)
        {
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return Value.ToString(format, formatProvider);
        }
    }
}
