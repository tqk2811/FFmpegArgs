using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC overlay           VV->V      Overlay a video source on top of the input.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#overlay-1 
    /// </summary>
    public class OverlayFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport, IFramesync
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "main_w","W",
            "main_h","H",
            "overlay_w", "w",
            "overlay_h", "h",
            "x", "y",
            "hsub", "vsub",
            "n", "pos","t"
        };

        readonly Expression expression = new Expression(_variables);

        internal OverlayFilter(ImageMap bottom, ImageMap top) : base("overlay", bottom, top)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public OverlayFilter X(string x)
            => this.X(x.Expression());
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public OverlayFilter X(Action<Expression> x)
            => this.SetOption("x", x.Run(expression));
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayFilter Y(string y)
            => this.Y(y.Expression());
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayFilter Y(Action<Expression> y)
            => this.SetOption("y", y.Run(expression));
        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayFilter XY(string x, string y)
            => this.X(x.Expression()).Y(y.Expression());

        /// <summary>
        /// Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayFilter XY(Action<Expression> x, Action<Expression> y)
            => this.X(x).Y(y);


        /// <summary>
        /// Set when the expressions for x, and y are evaluated.
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        public OverlayFilter Eval(OverlayEval eval)
          => this.SetOption("eval", eval.ToString().ToLower());

        /// <summary>
        /// Set the format for the output video.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public OverlayFilter Format(OverlayPixFmt format)
           => this.SetOption("format", format.ToString());

        /// <summary>
        /// Set format of alpha of the overlaid video, it can be straight or premultiplied. Default is straight.
        /// </summary>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public OverlayFilter Alpha(OverlayAlpha alpha)
          => this.SetOption("alpha", alpha.ToString().ToLower());
    }

    public static class OverlayFilterExtension
    {
        /// <summary>
        /// Overlay one video on top of another.<br>
        /// </br>It takes two inputs and has one output.The first input is the "main" video on which the second input is overlaid.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <returns></returns>
        public static OverlayFilter OverlayFilterOn(this ImageMap top, ImageMap bottom)
            => new OverlayFilter(bottom, top);

        /// <summary>
        /// Overlay one video on top of another.<br>
        /// </br>It takes two inputs and has one output.The first input is the "main" video on which the second input is overlaid.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <param name="x">Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).</param>
        /// <param name="y">Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).</param>
        /// <returns></returns>
        public static OverlayFilter OverlayFilterOn(this ImageMap top, ImageMap bottom, Action<Expression> x, Action<Expression> y)
            => new OverlayFilter(bottom, top).X(x).Y(y);

        /// <summary>
        /// Overlay one video on top of another.<br>
        /// </br>It takes two inputs and has one output.The first input is the "main" video on which the second input is overlaid.
        /// </summary>
        /// <param name="top"></param>
        /// <param name="bottom"></param>
        /// <param name="x">Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).</param>
        /// <param name="y">Set the expression for the x and y coordinates of the overlaid video on the main video. Default value is "0" for both expressions. In case the expression is invalid, it is set to a huge value (meaning that the overlay will not be displayed within the output visible area).</param>
        /// <returns></returns>

        public static OverlayFilter OverlayFilterOn(this ImageMap top, ImageMap bottom, string x, string y)
            => new OverlayFilter(bottom, top).X(x).Y(y);

        /// <summary>
        /// Overlay a video source on top of the input.
        /// </summary>
        public static OverlayFilter OverlayFilterGen(this ImageMap top, ImageMap bottom, OverlayFilterConfig config)
        {
            var result = new OverlayFilter(bottom, top);
            if (!string.IsNullOrWhiteSpace(config?.X)) result.X(config.X);
            if (!string.IsNullOrWhiteSpace(config?.Y)) result.Y(config.Y);
            if (config?.EofAction != null) result.EofAction(config.EofAction.Value);
            if (config?.Eval != null) result.Eval(config.Eval.Value);
            if (config?.Shortest != null) result.Shortest(config.Shortest.Value);
            if (config?.Format != null) result.Format(config.Format.Value);
            if (config?.Repeatlast != null) result.Repeatlast(config.Repeatlast.Value);
            if (config?.Alpha != null) result.Alpha(config.Alpha.Value);
            if (!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
            return result;
        }
    }

    public class OverlayFilterConfig : ITimelineSupportConfig
    {
        /// <summary>
        ///  set the x expression (default "0")
        /// </summary>
        public string X { get; set; }
        /// <summary>
        ///  set the y expression (default "0")
        /// </summary>
        public string Y { get; set; }
        /// <summary>
        ///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
        /// </summary>
        public EofAction? EofAction { get; set; }
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default frame)
        /// </summary>
        public OverlayEval? Eval { get; set; }
        /// <summary>
        ///  force termination when the shortest input terminates (default false)
        /// </summary>
        public bool? Shortest { get; set; }
        /// <summary>
        ///  set output format (from 0 to 7) (default yuv420)
        /// </summary>
        public OverlayPixFmt? Format { get; set; }
        /// <summary>
        ///  repeat overlay of the last overlay frame (default true)
        /// </summary>
        public bool? Repeatlast { get; set; }
        /// <summary>
        ///  alpha format (from 0 to 1) (default straight)
        /// </summary>
        public OverlayAlpha? Alpha { get; set; }
        public string TimelineSupport { get; set; }
    }
    public enum OverlayAlpha
    {
        Straight,
        Premultiplied
    }

    public enum OverlayPixFmt
    {
        /// <summary>
        /// force YUV420 output
        /// </summary>
        yuv420,
        /// <summary>
        /// force YUV420p10 output
        /// </summary>
        yuv420p10,
        /// <summary>
        /// force YUV422 output
        /// </summary>
        yuv422,
        /// <summary>
        /// force YUV422p10 output
        /// </summary>
        yuv422p10,
        /// <summary>
        /// force YUV444 output
        /// </summary>
        yuv444,
        /// <summary>
        /// force packed RGB output
        /// </summary>
        rgb,
        /// <summary>
        /// force planar RGB output
        /// </summary>
        gbrp,
        /// <summary>
        /// automatically pick format
        /// </summary>
        auto
    }

    /// <summary>
    /// Set when the expressions for x, and y are evaluated.
    /// </summary>
    public enum OverlayEval
    {
        /// <summary>
        /// only evaluate expressions once during the filter initialization or when a command is processed
        /// </summary>
        Init,

        /// <summary>
        /// evaluate expressions for each incoming frame
        /// </summary>
        Frame
    }

}