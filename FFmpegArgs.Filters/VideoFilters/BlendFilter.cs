using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// TS. blend             VV->V      Blend two video frames into each other.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#blend-1
  /// </summary>
  public class BlendFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, IFramesync
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "N",
      "X", "Y",
      "W", "H",
      "SW", "SH",
      "T",
      "TOP", "A",
      "BOTTOM", "B"
    };
    readonly Expression expression = new Expression(_variables);
    internal BlendFilter(IImageMap top, IImageMap bottom) : base("blend", top, bottom)
    {
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{this.FilterIndex}"));
    }

    public BlendFilter C0_Mode(BlendMode blendMode)
      => this.SetOption("c0_mode", blendMode);
    public BlendFilter C1_Mode(BlendMode blendMode)
      => this.SetOption("c1_mode", blendMode);
    public BlendFilter C2_Mode(BlendMode blendMode)
      => this.SetOption("c2_mode", blendMode);
    public BlendFilter C3_Mode(BlendMode blendMode)
      => this.SetOption("c3_mode", blendMode);
    public BlendFilter All_Mode(BlendMode blendMode)
      => this.SetOption("all_mode", blendMode);

    public BlendFilter C0_Opacity(float opacity)
      => this.SetOption("c0_opacity", opacity);
    public BlendFilter C1_Opacity(float opacity)
      => this.SetOption("c1_opacity", opacity);
    public BlendFilter C2_Opacity(float opacity)
      => this.SetOption("c2_opacity", opacity);
    public BlendFilter C3_Opacity(float opacity)
      => this.SetOption("c3_opacity", opacity);
    public BlendFilter All_Opacity(float opacity)
      => this.SetOption("all_opacity", opacity);

    public BlendFilter C0_Expr(Action<Expression> expr)
      => this.SetOption("c0_expr", expr.Run(expression));
    public BlendFilter C0_Expr(string expr)
     => C0_Expr(expr.Expression());
    public BlendFilter C1_Expr(Action<Expression> expr)
      => this.SetOption("c1_expr", expr.Run(expression));
    public BlendFilter C1_Expr(string expr)
     => C1_Expr(expr.Expression());
    public BlendFilter C2_Expr(Action<Expression> expr)
      => this.SetOption("c2_expr", expr.Run(expression));
    public BlendFilter C2_Expr(string expr)
     => C2_Expr(expr.Expression());
    public BlendFilter C3_Expr(Action<Expression> expr)
      => this.SetOption("c3_expr", expr.Run(expression));
    public BlendFilter C3_Expr(string expr)
     => C3_Expr(expr.Expression());
    public BlendFilter All_Expr(Action<Expression> expr)
      => this.SetOption("all_expr", expr.Run(expression));
    public BlendFilter All_Expr(string expr)
     => All_Expr(expr.Expression());
  }



  public static class BlendFilterExtension
  {
    public static BlendFilter BlendFilterOn(this IImageMap top, IImageMap bottom)
    {
      return new BlendFilter(top, bottom);
    }
  }

  public enum BlendMode
  {
    addition,
    and,
    average,
    bleach,
    burn,
    darken,
    difference,
    divide,
    dodge,
    exclusion,
    extremity,
    freeze,
    geometric,
    glow,
    grainextract,
    grainmerge,
    hardlight,
    hardmix,
    hardoverlay,
    harmonic,
    heat,
    interpolate,
    lighten,
    linearlight,
    multiply,
    multiply128,
    negation,
    normal,
    or,
    overlay,
    phoenix,
    pinlight,
    reflect,
    screen,
    softdifference,
    softlight,
    stain,
    subtract,
    vividlight,
    xor
  }
}
