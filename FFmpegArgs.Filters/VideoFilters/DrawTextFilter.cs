using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// T.C drawtext          V->V       Draw text on top of video frames using libfreetype library.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#drawtext-1 
  /// </summary>
  public class DrawTextFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "dar",
      "hsub", "vsub",
      "line_h", "lh",
      "main_h", "h", "H",
      "main_w", "w", "W",
      "max_glyph_a, ascent",
      "max_glyph_d, descent",
      "max_glyph_h", "max_glyph_w",
      "n", "sar", "t",
      "text_h", "th",
      "text_w", "tw",
      "x", "y",
      "pict_type",
      "pkt_pos",
      "pkt_duration",
      "pkt_size"
    };

    readonly Expression expression = new Expression(_variables);
    internal DrawTextFilter(string text, ImageMap imageMap) : base("drawtext", imageMap)
    {
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{this.FilterIndex}"));
      this.SetOption("text", text.FiltergraphEscapingLv1().FiltergraphEscapingLv2());
    }

    public DrawTextFilter FontColor(Color color)
      => this.SetOption("fontcolor", color.ToHexStringRGB());

    public DrawTextFilter Font(string name)
      => this.SetOption("font", name.FiltergraphEscapingLv1().FiltergraphEscapingLv2());

    public DrawTextFilter FontFile(string path)
      => this.SetOption("fontfile", path.FiltergraphEscapingLv1().FiltergraphEscapingLv2());

    public DrawTextFilter FontSize(int size)
    {
      if (size < 0) throw new InvalidRangeException($"{nameof(size)} < 0");
      return this.SetOption("fontsize", size);
    }

    public DrawTextFilter Pos(Action<Expression> x, Action<Expression> y)
      => this.SetOption("x", x.Run(expression)).SetOption("y", y.Run(expression));

    public DrawTextFilter Pos(string x, string y)
      => Pos(x.Expression(), y.Expression());
  }

  public static class DrawTextFilterExtension
  {
    public static DrawTextFilter DrawTextFilter(this ImageMap imageMap, string text)
    {
      return new DrawTextFilter(text, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }
  }
}
