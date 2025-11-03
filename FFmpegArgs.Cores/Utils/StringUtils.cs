using System.Globalization;

namespace FFmpegArgs.Cores.Utils
{
    internal static class StringUtils
    {
        // Constants

        private static readonly CultureInfo Invariant = CultureInfo.InvariantCulture;
        private const StringComparison Ordinal = StringComparison.Ordinal;
        private const NumberStyles IntegerNumberStyle = NumberStyles.Integer;
        private const NumberStyles FloatingNumberStyle = NumberStyles.Float | NumberStyles.AllowThousands;

        // Formattable

        public static string Inv(FormattableString @this) =>
            FormattableString.Invariant(@this);

        // String

        public static string ToStringInv(this string @this) =>
            @this;

        public static string ToStringInv<T>(this T @this) where T : IFormattable =>
            @this.ToString(null, Invariant);

        public static string ToStringInv<T>(this T @this, string format) where T : IFormattable =>
            @this.ToString(format, Invariant);

        public static bool EqualsOrd(this string @this, string value) =>
            @this.Equals(value, Ordinal);

        public static bool ContainsOrd(this string @this, string value) =>
#if NET5_0_OR_GREATER
            @this.Contains(value, Ordinal);
#else
            @this.IndexOf(value, Ordinal) != -1;
#endif

        public static bool ContainsOrd(this string @this, char value) =>
#if NET5_0_OR_GREATER
            @this.Contains(value, Ordinal);
#else
            @this.IndexOf(value.ToString(Invariant), Ordinal) != -1;
#endif

        public static string ReplaceOrd(this string @this, string oldValue, string? newValue) =>
#if NET5_0_OR_GREATER
            @this.Replace(oldValue, newValue, Ordinal);
#else
            @this.Replace(oldValue, newValue);
#endif

        public static bool StartsWithOrd(this string @this, string value) =>
            @this.StartsWith(value, Ordinal);

        // Parse Int32

        public static int ParseInt32(string s) => 
            int.Parse(s, IntegerNumberStyle, Invariant);

        public static int ParseInt32(string s, NumberStyles style) => 
            int.Parse(s, style, Invariant);

#if NET5_0_OR_GREATER
        public static bool TryParseInt32([NotNullWhen(true)] string? s, out int result) => 
            int.TryParse(s, IntegerNumberStyle, Invariant, out result);

        public static bool TryParseInt32(ReadOnlySpan<char> s, out int result) => 
            int.TryParse(s, IntegerNumberStyle, Invariant, out result);
#endif

#if NET8_0_OR_GREATER
        public static bool TryParseInt32(ReadOnlySpan<byte> utf8Text, out int result) => 
            int.TryParse(utf8Text, IntegerNumberStyle, Invariant, out result);
#endif

        // Parse Double

        public static double ParseDouble(string s) => 
            double.Parse(s, FloatingNumberStyle, Invariant);

        public static double ParseDouble(string s, NumberStyles style) => 
            double.Parse(s, style, Invariant);

#if NET5_0_OR_GREATER
        public static bool TryParseDouble([NotNullWhen(true)] string? s, out double result) => 
            double.TryParse(s, FloatingNumberStyle, Invariant, out result);

        public static bool TryParseDouble(ReadOnlySpan<char> s, out double result) => 
            double.TryParse(s, FloatingNumberStyle, Invariant, out result);
#endif

#if NET8_0_OR_GREATER
        public static bool TryParseDouble(ReadOnlySpan<byte> utf8Text, out double result) => 
            double.TryParse(utf8Text, FloatingNumberStyle, Invariant, out result);
#endif

        // Parse Single

        public static float ParseSingle(string s) => 
            float.Parse(s, FloatingNumberStyle, Invariant);

        public static float ParseSingle(string s, NumberStyles style) => 
            float.Parse(s, style, Invariant);

#if NET5_0_OR_GREATER
        public static bool TryParseSingle([NotNullWhen(true)] string? s, out float result) => 
            float.TryParse(s, FloatingNumberStyle, Invariant, out result);

        public static bool TryParseSingle(ReadOnlySpan<char> s, out float result) => 
            float.TryParse(s, FloatingNumberStyle, Invariant, out result);
#endif

#if NET8_0_OR_GREATER
        public static bool TryParseSingle(ReadOnlySpan<byte> utf8Text, out float result) => 
            float.TryParse(utf8Text, FloatingNumberStyle, Invariant, out result);
#endif
    }
}