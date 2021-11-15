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
        internal PadFilter(ImageMap imageMap) : base("pad", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br></br>
        /// The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public PadFilter Size(string w, string h)
          => Size(w.Expression(),h.Expression());

        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br></br>
        /// The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <returns></returns>
        public PadFilter Size(Action<Expression> w, Action<Expression> h)
          => this.SetOption("w", w.Run(expression)).SetOption("h", h.Run(expression));

        /// <summary>
        /// Specify the offsets to place the input image at within the padded area, with respect to the top/left border of the output image.<br></br>
        /// The x expression can reference the value set by the y expression, and vice versa.<br></br>
        /// The default value of x and y is 0.<br></br>
        /// If x or y evaluate to a negative number, they’ll be changed so the input image is centered on the padded area.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PadFilter Position(Action<Expression> x, Action<Expression> y)
          => this.SetOption("x", x.Run(expression)).SetOption("y", y.Run(expression));

        /// <summary>
        /// Specify the offsets to place the input image at within the padded area, with respect to the top/left border of the output image.<br></br>
        /// The x expression can reference the value set by the y expression, and vice versa.<br></br>
        /// The default value of x and y is 0.<br></br>
        /// If x or y evaluate to a negative number, they’ll be changed so the input image is centered on the padded area.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PadFilter Position(string x, string y)
          => Position(x.Expression(), y.Expression());

        /// <summary>
        /// Specify the color of the padded area.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public PadFilter Color(Color color)
          => this.SetOption("color", color.ToHexStringRGBA());

        /// <summary>
        /// Specify when to evaluate width, height, x and y expression.
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        public PadFilter Eval(PadEval eval)
          => this.SetOption("eval", eval.ToString().ToLower());

        /// <summary>
        /// Pad to aspect instead to a resolution.
        /// </summary>
        /// <param name="rational"></param>
        /// <returns></returns>
        public PadFilter Aspect(Rational rational)
            => this.SetOption("aspect", rational.Check(0, DBL_MAX));
    }

    public static class PadFilterExtension
    {
        /// <summary>
        /// Add paddings to the input image, and place the original input at the provided x, y coordinates.
        /// </summary>
        public static PadFilter PadFilter(this ImageMap imageMap)
            => new PadFilter(imageMap);
        /// <summary>
        /// Add paddings to the input image, and place the original input at the provided x, y coordinates.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public static PadFilter PadFilter(this ImageMap imageMap, Action<Expression> w, Action<Expression> h)
            => new PadFilter(imageMap).Size(w, h);
        /// <summary>
        /// Add paddings to the input image, and place the original input at the provided x, y coordinates.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public static PadFilter PadFilter(this ImageMap imageMap, string w, string h)
            => new PadFilter(imageMap).Size(w, h);
    }

    #region Enum
    public enum PadEval
    {
        Init,
        Frame
    }
    #endregion
}
