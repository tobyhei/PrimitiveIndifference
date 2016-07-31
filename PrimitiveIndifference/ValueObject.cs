using System;

namespace PrimitiveIndifference
{
    public class ValueObject<T>
        where T : IComparable, IConvertible, IComparable<T>, IEquatable<T>
    {
        protected readonly T Value;

        protected ValueObject(T value)
        {
            Value = value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator T(ValueObject<T> valueObject)
        {
            return valueObject.Value;
        }

        public override bool Equals(object other)
        {
            var otherVal = other as ValueObject<T>;

            return !ReferenceEquals(otherVal, null) && otherVal.Value.Equals(Value);
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
