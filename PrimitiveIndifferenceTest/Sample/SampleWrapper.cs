using System;
using PrimitiveIndifference;

namespace PrimitiveIndifferenceTest.Sample
{
    public class ByteWrapper : FormattablePrimitiveWrapper<byte>
    {
        public ByteWrapper(byte value) : base(value) {}
    }

    public class ShortWrapper : FormattablePrimitiveWrapper<short>
    {
        public ShortWrapper(short value) : base(value) {}
    }

    public class IntWrapper : FormattablePrimitiveWrapper<int>
    {
        public IntWrapper(int value) : base(value) {}
    }

    public class LongWrapper : FormattablePrimitiveWrapper<long>
    {
        public LongWrapper(long value) : base(value) {}
    }

    public class FloatWrapper : FormattablePrimitiveWrapper<float>
    {
        public FloatWrapper(float value) : base(value) {}
    }

    public class DoubleWrapper : FormattablePrimitiveWrapper<double>
    {
        public DoubleWrapper(double value) : base(value) {}
    }

    public class DecimalWrapper : FormattablePrimitiveWrapper<decimal>
    {
        public DecimalWrapper(decimal value) : base(value) {}
    }

    public class DateWrapper : FormattablePrimitiveWrapper<DateTime>
    {
        public DateWrapper(DateTime value) : base(value) { }
    }

    public class BoolWrapper : PrimitiveWrapper<bool>
    {
        public BoolWrapper(bool value) : base(value) {}
    }

    public class CharWrapper : PrimitiveWrapper<char>
    {
        public CharWrapper(char value) : base(value) {}
    }

    public class UserName : PrimitiveWrapper<string>
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
