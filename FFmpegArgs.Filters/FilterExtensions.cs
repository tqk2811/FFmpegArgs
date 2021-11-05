﻿using FFmpegArgs.Utils;
using System;
using System.Drawing;
using System.Linq;

namespace FFmpegArgs.Filters
{
  public static class FilterExtensions
  {
    public static string ToHexStringRGB(this Color color)
    {
      return $"0x{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
    }
    public static string ToHexStringRGBA(this Color color)
    {
      return $"0x{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}{color.A.ToString("X2")}";
    }

    public static Expression Run(this Action<Expression> action, Expression expression)
    {
      action?.Invoke(expression);
      return expression;
    }

    public static Action<Expression> Expression(this string str)
      => new Action<Expression>(_e => _e.Check(str));

    public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
    {
      var enumType = value.GetType();
      var name = Enum.GetName(enumType, value);
      return enumType.GetField(name)?.GetCustomAttributes(false).OfType<TAttribute>().SingleOrDefault();
    }
  }
}
