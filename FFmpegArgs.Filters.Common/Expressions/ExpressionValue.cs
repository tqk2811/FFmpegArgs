namespace FFmpegArgs.Filters.Expressions
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class ExpressionValue
    {
        public string Value { get; }


        public ExpressionValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
            this.Value = value;
        }
        public ExpressionValue(UInt16 value)
        {
            this.Value = value.ToString();
        }
        public ExpressionValue(UInt32 value)
        {
            this.Value = value.ToString();
        }
        public ExpressionValue(UInt64 value)
        {
            this.Value = value.ToString();
        }
#if NET7_0_OR_GREATER
        public ExpressionValue(UInt128 value)
        {
            this.Value = value.ToString();
        }
#endif


        public ExpressionValue(Int16 value)
        {
            this.Value = value.ToString();
        }
        public ExpressionValue(Int32 value)
        {
            this.Value = value.ToString();
        }
        public ExpressionValue(Int64 value)
        {
            this.Value = value.ToString();
        }
#if NET7_0_OR_GREATER
        public ExpressionValue(Int128 value)
        {
            this.Value = value.ToString();
        }
#endif

        public ExpressionValue(float value)
        {
            this.Value = value.ToString();
        }
        public ExpressionValue(double value)
        {
            this.Value = value.ToString();
        }
        public ExpressionValue(decimal value)
        {
            this.Value = value.ToString();
        }
        public ExpressionValue(Rational value)
        {
            this.Value = value.ToString();
        }

        public override string ToString() => this.Value;


        public static implicit operator ExpressionValue(string value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(Int16 value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(Int32 value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(Int64 value) => new ExpressionValue(value);
#if NET7_0_OR_GREATER
        public static implicit operator ExpressionValue(Int128 value) => new ExpressionValue(value);
#endif
        public static implicit operator ExpressionValue(UInt16 value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(UInt32 value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(UInt64 value) => new ExpressionValue(value);
#if NET7_0_OR_GREATER
        public static implicit operator ExpressionValue(UInt128 value) => new ExpressionValue(value);
#endif
        public static implicit operator ExpressionValue(float value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(double value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(decimal value) => new ExpressionValue(value);
        public static implicit operator ExpressionValue(Rational value) => new ExpressionValue(value);


        public static explicit operator string(ExpressionValue expressionValue) => expressionValue.Value;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
