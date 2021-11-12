using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... pad               V->V       Pad the input video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#pad-1 
    /// </summary>
    public class PadFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "in_w", "in_h", "iw", "ih",
            "out_w", "out_h", "ow", "oh",
            "x","y","a","sar","dar",
            "hsub", "vsub"
        };
        readonly Expression expression = new Expression(_variables);
        internal PadFilter(Action<Expression> w, Action<Expression> h, ImageMap imageMap) : base("pad", imageMap)
        {
            AddMapOut();
            this.SetOption("w", w.Run(expression));
            this.SetOption("h", h.Run(expression));
        }

        public PadFilter Position(Action<Expression> x, Action<Expression> y)
          => this.SetOption("x", x.Run(expression)).SetOption("y", y.Run(expression));

        public PadFilter Position(string x, string y)
          => Position(x.Expression(), y.Expression());

        public PadFilter Color(Color color)
          => this.SetOption("color", color.ToHexStringRGBA());

        public PadFilter Eval(PadEval eval)
          => this.SetOption("eval", eval.ToString().ToLower());
    }

    public static class PadFilterExtension
    {
        public static PadFilter PadFilter(this ImageMap imageMap, Action<Expression> w, Action<Expression> h)
        {
            return new PadFilter(w, h, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
        }
        public static PadFilter PadFilter(this ImageMap imageMap, string w, string h)
        {
            return new PadFilter(w.Expression(), h.Expression(), imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
        }
    }

    #region Enum
    public enum PadEval
    {
        Init,
        Frame
    }
    #endregion
}
