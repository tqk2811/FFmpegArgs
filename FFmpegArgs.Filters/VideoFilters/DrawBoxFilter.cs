using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.C drawbox           V->V       Draw a colored box on the input video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#drawbox 
    /// </summary>
    public class DrawBoxFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "dar",
            "hsub", "vsub",
            "in_h", "ih",
            "in_w", "iw",
            "sar",
            "x", "y",
            "w", "h",
            "t"
        };

        readonly Expression expression = new Expression(_variables);
        internal DrawBoxFilter(ImageMap imageMap) : base("drawbox", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// The expressions which specify the top left corner coordinates of the box. It defaults to 0.
        /// </summary>
        public DrawBoxFilter X(string x)
            => this.X(x.Expression());
        /// <summary>
        /// The expressions which specify the top left corner coordinates of the box. It defaults to 0.
        /// </summary>
        public DrawBoxFilter X(Action<Expression> x)
            => this.SetOption("x", x.Run(expression));
        /// <summary>
        /// The expressions which specify the top left corner coordinates of the box. It defaults to 0.
        /// </summary>
        public DrawBoxFilter Y(string y)
            => this.Y(y.Expression());
        /// <summary>
        /// The expressions which specify the top left corner coordinates of the box. It defaults to 0.
        /// </summary>
        public DrawBoxFilter Y(Action<Expression> y)
            => this.SetOption("y", y.Run(expression));
        /// <summary>
        /// The expressions which specify the width and height of the box; if 0 they are interpreted as the input width and height. It defaults to 0.
        /// </summary>
        public DrawBoxFilter W(string w)
            => this.W(w.Expression());
        /// <summary>
        /// The expressions which specify the width and height of the box; if 0 they are interpreted as the input width and height. It defaults to 0.
        /// </summary>
        public DrawBoxFilter W(Action<Expression> w)
            => this.SetOption("w", w.Run(expression));
        /// <summary>
        /// The expressions which specify the width and height of the box; if 0 they are interpreted as the input width and height. It defaults to 0.
        /// </summary>
        public DrawBoxFilter H(string h)
            => this.H(h.Expression());
        /// <summary>
        /// The expressions which specify the width and height of the box; if 0 they are interpreted as the input width and height. It defaults to 0.
        /// </summary>
        public DrawBoxFilter H(Action<Expression> h)
            => this.SetOption("h", h.Run(expression));

        /// <summary>
        /// Specify the color of the box to write. If the special value invert is used, the box edge color is the same as the video with inverted luma.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public DrawBoxFilter Color(Color color)
            => this.SetOption("c", color.ToHexStringRGBA());

        /// <summary>
        /// The expression which sets the thickness of the box edge. A value of fill will create a filled box. Default value is 3.
        /// </summary>
        public DrawBoxFilter ThicknessFill()
          => this.SetOption("t", "fill");

        /// <summary>
        /// The expression which sets the thickness of the box edge. A value of fill will create a filled box. Default value is 3.
        /// </summary>
        public DrawBoxFilter Thickness(Action<Expression> t)
          => this.SetOption("t", t.Run(expression));

        /// <summary>
        /// The expression which sets the thickness of the box edge. A value of fill will create a filled box. Default value is 3.
        /// </summary>
        public DrawBoxFilter Thickness(string t)
          => Thickness(_t => _t.Check(t));

        /// <summary>
        /// Applicable if the input has alpha. With value 1, the pixels of the painted box will overwrite the video’s color and alpha pixels. Default is 0, which composites the box onto the input, leaving the video’s alpha intact.
        /// </summary>
        public DrawBoxFilter Replace(bool replace)
           => this.SetOption("replace", replace.ToFFmpegFlag());
    }

    public static class DrawBoxFilterExtension
    {
        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static DrawBoxFilter DrawBoxFilter(this ImageMap imageMap, Color color,
          Action<Expression> x, Action<Expression> y, Action<Expression> w, Action<Expression> h)
            => new DrawBoxFilter(imageMap ?? throw new ArgumentNullException(nameof(imageMap)))
                .X(x).Y(y).W(w).H(h).Color(color);

        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static DrawBoxFilter DrawBoxFilter(this ImageMap imageMap, Color color,
         string x = "0", string y = "0", string w = "0", string h = "0")
            => new DrawBoxFilter(imageMap ?? throw new ArgumentNullException(nameof(imageMap)))
                .X(x).Y(y).W(w).H(h).Color(color);

        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static DrawBoxFilter DrawBoxFilter(this ImageMap imageMap)
            => new DrawBoxFilter(imageMap ?? throw new ArgumentNullException(nameof(imageMap)));

        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static DrawBoxFilter DrawboxFilter(this ImageMap input0, DrawboxFilterConfig config)
        {
            var result = new DrawBoxFilter(input0);
            if (!string.IsNullOrWhiteSpace(config?.X)) result.X(config.X);
            if (!string.IsNullOrWhiteSpace(config?.Y)) result.Y(config.Y);
            if (!string.IsNullOrWhiteSpace(config?.W)) result.W(config.W);
            if (!string.IsNullOrWhiteSpace(config?.H)) result.H(config.H);
            if (config?.Color != null) result.Color(config.Color.Value);
            if (!string.IsNullOrWhiteSpace(config?.Thickness)) result.Thickness(config.Thickness);
            if (config?.Replace != null) result.Replace(config.Replace.Value);
            if (!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
            return result;
        }
    }

    public class DrawboxFilterConfig : ITimelineSupportConfig
    {
        /// <summary>
        ///  set horizontal position of the left box edge (default "0")
        /// </summary>
        public string X { get; set; }
        /// <summary>
        ///  set vertical position of the top box edge (default "0")
        /// </summary>
        public string Y { get; set; }
        /// <summary>
        ///  set width of the box (default "0")
        /// </summary>
        public string W { get; set; }
        /// <summary>
        ///  set height of the box (default "0")
        /// </summary>
        public string H { get; set; }
        /// <summary>
        ///  set color of the box (default "black")
        /// </summary>
        public Color? Color { get; set; }
        /// <summary>
        ///  set the box thickness (default "3")
        /// </summary>
        public string Thickness { get; set; }
        /// <summary>
        ///  replace color & alpha (default false)
        /// </summary>
        public bool? Replace { get; set; }
        public string TimelineSupport { get; set; }
    }
}
