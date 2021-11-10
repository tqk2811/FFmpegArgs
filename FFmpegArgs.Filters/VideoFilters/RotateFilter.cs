using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC rotate            V->V       Rotate the input image.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#rotate 
    /// </summary>
    public class RotateFilter : ImageToImageFilter, ICommandSupport, ITimelineSupport, ISliceThreading
    {
        static readonly IEnumerable<string> _variables = new List<string>()
    {
      "n", "t",
      "hsub","vsub",
      "in_w", "iw",
      "in_h","ih",
      "out_w", "ow",
      "out_h", "oh"
    };
        static readonly IEnumerable<ShuntingYardFunction> _func = new List<ShuntingYardFunction>()
    {
      new ShuntingYardFunction("rotw","rotw_1"),
      new ShuntingYardFunction("roth","roth_1"),
    };
        readonly Expression expression = new Expression(_variables, _func);

        internal RotateFilter(Action<Expression> angle, ImageMap imageMap) : base("rotate", imageMap)
        {
            AddMapOut();
            this.SetOption("a", angle.Run(expression));
        }
        public RotateFilter OW(string ow)
            => OW(ow.Expression());
        public RotateFilter OW(Action<Expression> ow)
            => this.SetOption("ow", ow.Run(expression));
        public RotateFilter OH(string oh)
            => OH(oh.Expression());
        public RotateFilter OH(Action<Expression> oh)
            => this.SetOption("oh", oh.Run(expression));

        public RotateFilter OutWH(string ow, string oh)
          => OutWH(ow.Expression(), oh.Expression());
        public RotateFilter OutWH(Action<Expression> ow, Action<Expression> oh)
          => this.SetOption("ow", ow.Run(expression)).SetOption("oh", oh.Run(expression));

        public RotateFilter Bilinear(bool flag)
          => this.SetOption("bilinear", flag.ToFFmpegFlag());

        public RotateFilter FillColor(Color color)
           => this.SetOption("c", color.ToHexStringRGBA());
    }

    public static class RotateFilterExtension
    {
        public static RotateFilter RotateFilter(this ImageMap imageMap, Action<Expression> angle)
        {
            return new RotateFilter(angle, imageMap);
        }
        public static RotateFilter RotateFilter(this ImageMap imageMap, string angle)
        {
            return new RotateFilter(angle.Expression(), imageMap);
        }


    }
}
