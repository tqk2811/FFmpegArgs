using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using FFmpegArgs.Expressions;
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
            AddMapOut();
            this.SetOption("text", text);
        }

        public DrawTextFilter FontColor(Color color)
          => this.SetOption("fontcolor", color.ToHexStringRGB());

        public DrawTextFilter Font(string name)
          => this.SetOption("font", name);

        public DrawTextFilter FontFile(string path)
          => this.SetOption("fontfile", path);

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
            => new DrawTextFilter(text, imageMap);
    }
}
