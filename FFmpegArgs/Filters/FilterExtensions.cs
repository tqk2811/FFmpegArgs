using FFmpegArgs.Expressions;
using System;
using System.Drawing;
using System.Linq;

namespace FFmpegArgs.Filters
{
    public static class FilterExtensions
    {
        public static string ToFFmpegFlag(this bool flag)
        {
            return flag ? "1" : "0";
        }
        public static int EnsureOdd(this int input)
        {
            if (input % 2 == 0) throw new InvalidOperationException("required input odd");
            return input;
        }
        public static int EnsureEven(this int input)
        {
            if (input % 2 != 0) throw new InvalidOperationException("required input even");
            return input;
        }
        public static string ToHexStringRGB(this Color color)
        {
            return $"0x{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
        }
        public static string ToHexStringRGBA(this Color color)
        {
            return $"0x{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}{color.A.ToString("X2")}";
        }

        public static FFmpegExpression Run(this Action<FFmpegExpression> action, FFmpegExpression expression)
        {
            action?.Invoke(expression);
            return expression;
        }

        public static Action<FFmpegExpression> Expression(this string str)
          => new Action<FFmpegExpression>(_e => _e.Check(str));

        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            var enumType = value.GetType();
            var name = Enum.GetName(enumType, value);
            return enumType.GetField(name)?.GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault();
        }
    }
}
