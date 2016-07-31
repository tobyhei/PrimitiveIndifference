using System;

namespace PrimitiveIndifference
{
    public class PrimitiveWrapper<T>
        where T : IComparable, IConvertible, IComparable<T>, IEquatable<T>
    {
        protected readonly T Value;

        protected PrimitiveWrapper(T value)
        {
            Value = value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator T(PrimitiveWrapper<T> wrapper)
        {
            return wrapper.Value;
        }

        public override bool Equals(object other)
        {
            var otherVal = other as PrimitiveWrapper<T>;

            return !ReferenceEquals(otherVal, null) && otherVal.Value.Equals(Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
