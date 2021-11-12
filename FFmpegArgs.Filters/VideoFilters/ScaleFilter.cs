using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters.Enums;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ..C scale             V->V       Scale the input video size and/or convert the image format.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#scale-1 
    /// </summary>
    public class ScaleFilter : ImageToImageFilter, ICommandSupport
    {
        static readonly IEnumerable<string> _scalevariables = new List<string>()
    {
      "in_w", "iw",
      "in_h", "ih",
      "out_w", "ow",
      "out_h", "oh",
      "a",
      "sar", "dar",
      "hsub", "vsub",
      "ohsub", "ovsub",
      "n", "t",
      "pos"
    };

        internal ScaleFilter(Action<Expression> w, Action<Expression> h, ImageMap imageMap) : base("scale", imageMap)
        {
            AddMapOut();

            Expression expression = new Expression(_scalevariables);
            this.SetOption("w", w.Run(expression));
            this.SetOption("h", h.Run(expression));
        }

        public ScaleFilter Eval(ScaleEval eval)
          => this.SetOption("eval", eval.ToString().ToLower());

        public ScaleFilter Interl(ScaleInterl interl)
          => this.SetOption("interl", (int)interl);

        public ScaleFilter Flags(SwsFlags flag)
          => this.SetOption("flags", flag.ToString());

        public ScaleFilter Size(VideoSizeUtils videoSize)
          => this.SetOption("s", videoSize.GetAttribute<NameAttribute>().Name);

        public ScaleFilter InColorMatrix(ScaleColorMatrix colorMatrix)
          => this.SetOption("in_color_matrix", colorMatrix);

        public ScaleFilter OutColorMatrix(ScaleColorMatrix colorMatrix)
          => this.SetOption("out_color_matrix", colorMatrix);

        public ScaleFilter ForceOriginalAspectRatio(ScaleAspectRatio ratio)
          => this.SetOption("force_original_aspect_ratio", ratio);
    }

    public static class ScaleFilterExtension
    {
        public static ScaleFilter ScaleFilter(this ImageMap imageMap, Action<Expression> w, Action<Expression> h)
        {
            return new ScaleFilter(w, h, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
        }
        public static ScaleFilter ScaleFilter(this ImageMap imageMap, string w, string h)
        {
            return new ScaleFilter(w.Expression(), h.Expression(), imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
        }
    }


    #region Enum
    public enum ScaleColorMatrix
    {
        auto,
        bt709,
        fcc,
        bt601,
        smpte170m,
        smpte240m,
        bt2020
    }

    public enum ScaleAspectRatio
    {
        disable,
        decrease,
        increase
    }

    /// <summary>
    /// Set the interlacing mode.
    /// </summary>
    public enum ScaleInterl
    {
        /// <summary>
        /// Force interlaced aware scaling.
        /// </summary>
        ForceInterlacedAwareScaling = 1,

        /// <summary>
        /// Do not apply interlaced scaling.
        /// </summary>
        DoNotApplyInterlacedScaling = 0,

        /// <summary>
        /// Select interlaced aware scaling depending on whether the source frames are flagged as interlaced or not.
        /// </summary>
        Optional = -1,
    }

    /// <summary>
    /// Specify when to evaluate width and height expression.
    /// </summary>
    public enum ScaleEval
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
    #endregion

}
