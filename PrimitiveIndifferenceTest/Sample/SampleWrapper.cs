using System;
using PrimitiveIndifference;

namespace PrimitiveIndifferenceTest.Sample
{
    public class ByteObject : FormattableValueObject<byte>
    {
        public ByteObject(byte value) : base(value) {}
    }

    public class ShortObject : FormattableValueObject<short>
    {
        public ShortObject(short value) : base(value) {}
    }

    public class IntObject : FormattableValueObject<int>
    {
        public IntObject(int value) : base(value) {}
    }

    public class LongObject : FormattableValueObject<long>
    {
        public LongObject(long value) : base(value) {}
    }

    public class FloatObject : FormattableValueObject<float>
    {
        public FloatObject(float value) : base(value) {}
    }

    public class DoubleObject : FormattableValueObject<double>
    {
        public DoubleObject(double value) : base(value) {}
    }

    public class DecimalObject : FormattableValueObject<decimal>
    {
        public DecimalObject(decimal value) : base(value) {}
    }

    public class DateObject : FormattableValueObject<DateTime>
    {
        public DateObject(DateTime value) : base(value) { }
    }

    public class BoolObject : ValueObject<bool>
    {
        public BoolObject(bool value) : base(value) {}
    }

    public class CharObject : ValueObject<char>
    {
        public CharObject(char value) : base(value) {}
    }

    public class UserName : ValueObject<string>
    {
        // public for testing purposes
        public const byte MaxUsernameLength = 30;

        public UserName(string username) : base(username?.ToUpper())
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                if (ReferenceEquals(username, null))
                {
                    throw new ArgumentNullException(nameof(username));
                }

                throw new ArgumentException($"{nameof(username)} was empty");
            }

            if (username.Length > MaxUsernameLength)
            {
                throw new ArgumentOutOfRangeException(
                    $"{nameof(username)} was longer than {nameof(MaxUsernameLength)} {MaxUsernameLength}");
            }
        }
    }
}
