using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;

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

        readonly FFmpegExpression expression = new FFmpegExpression(_scalevariables);
        internal ScaleFilter(ImageMap imageMap) : base("scale", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public ScaleFilter Width(Action<FFmpegExpression> w)
            => this.SetOption("w", w.Run(expression));

        /// <summary>
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public ScaleFilter Width(string w)
            => this.Width(w.Expression());

        /// <summary>
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public ScaleFilter Height(Action<FFmpegExpression> h)
           => this.SetOption("h", h.Run(expression));

        /// <summary>
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public ScaleFilter Height(string h)
            => this.Height(h.Expression());


        /// <summary>
        /// Set the video size
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public ScaleFilter Size(VideoSizeUtils videoSize)
          => this.SetOption("s", videoSize.GetAttribute<NameAttribute>().Name);

        /// <summary>
        /// Set the video size
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public ScaleFilter Size(Size videoSize)
          => this.SetOption("s", $"{videoSize.Width}x{videoSize.Height}");

        /// <summary>
        /// Specify when to evaluate width and height expression.
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        public ScaleFilter Eval(ScaleEval eval)
          => this.SetOption("eval", eval.ToString().ToLower());

        /// <summary>
        /// Set the interlacing mode
        /// </summary>
        /// <param name="interl"></param>
        /// <returns></returns>
        public ScaleFilter Interl(ScaleInterl interl)
          => this.SetOption("interl", (int)interl);

        /// <summary>
        /// Set libswscale scaling flags.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public ScaleFilter Flags(SwsFlags flag)
          => this.SetOption("flags", flag.ToString());

        /// <summary>
        /// Set scaling algorithm parameters. The specified values are specific of some scaling algorithms and ignored by others. The specified values are floating point number values.
        /// </summary>
        /// <param name="param0">Scaler param 0 (from INT_MIN to INT_MAX) (default 123456)</param>
        /// <returns></returns>
        public ScaleFilter Param0(double param0)
            => this.SetOptionRange("param0", param0, INT_MIN, INT_MAX);

        /// <summary>
        /// Set scaling algorithm parameters. The specified values are specific of some scaling algorithms and ignored by others. The specified values are floating point number values.
        /// </summary>
        /// <param name="param1">Scaler param 1 (from INT_MIN to INT_MAX) (default 123456)</param>
        /// <returns></returns>
        public ScaleFilter Param1(double param1)
            => this.SetOptionRange("param1", param1, INT_MIN, INT_MAX);

        /// <summary>
        /// Set in/output YCbCr color space type.<br></br>
        /// This allows the autodetected value to be overridden as well as allows forcing a specific value used for the output and encoder.<br></br>
        /// If not specified, the color space type depends on the pixel format.
        /// </summary>
        /// <param name="colorMatrix"></param>
        /// <returns></returns>
        public ScaleFilter InColorMatrix(ScaleColorMatrix colorMatrix)
          => this.SetOption("in_color_matrix", colorMatrix);

        /// <summary>
        /// Set in/output YCbCr color space type.<br></br>
        /// This allows the autodetected value to be overridden as well as allows forcing a specific value used for the output and encoder.<br></br>
        /// If not specified, the color space type depends on the pixel format.
        /// </summary>
        /// <param name="colorMatrix"></param>
        /// <returns></returns>
        public ScaleFilter OutColorMatrix(ScaleColorMatrix colorMatrix)
          => this.SetOption("out_color_matrix", colorMatrix);

        /// <summary>
        /// Set in/output YCbCr sample range.<br></br>
        /// This allows the autodetected value to be overridden as well as allows forcing a specific value used for the output and encoder.If not specified, the range depends on the pixel format.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public ScaleFilter InRange(ScaleRange range)
            => this.SetOption("in_range", range);

        /// <summary>
        /// Set in/output YCbCr sample range.<br></br>
        /// This allows the autodetected value to be overridden as well as allows forcing a specific value used for the output and encoder.If not specified, the range depends on the pixel format.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public ScaleFilter OutRange(ScaleRange range)
            => this.SetOption("out_range", range);
        /// <summary>
        /// Enable decreasing or increasing output video width or height if necessary to keep the original aspect ratio.
        /// </summary>
        /// <param name="colorMatrix"></param>
        /// <returns></returns>
        public ScaleFilter ForceOriginalAspectRatio(ScaleAspectRatio ratio)
          => this.SetOption("force_original_aspect_ratio", ratio);

        /// <summary>
        /// Ensures that both the output dimensions, width and height, are divisible by the given integer when used together with force_original_aspect_ratio. This works similar to using -n in the w and h options.<br></br>
        /// This option respects the value set for force_original_aspect_ratio, increasing or decreasing the resolution accordingly.The video’s aspect ratio may be slightly modified.<br></br>
        /// This option can be handy if you need to have a video fit within or exceed a defined resolution using force_original_aspect_ratio but also have encoder restrictions on width or height divisibility.<br></br>
        /// enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public ScaleFilter ForceDivisibleBy(int val)
            => this.SetOptionRange("force_divisible_by", val, 1, 256);
    }

    public static class ScaleFilterExtension
    {
        /// <summary>
        /// The filter accepts the following options, or any of the options supported by the libswscale scaler.
        /// </summary>
        public static ScaleFilter ScaleFilter(this ImageMap imageMap)
            => new ScaleFilter(imageMap);

        /// <summary>
        /// The filter accepts the following options, or any of the options supported by the libswscale scaler.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="w">
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </param>
        /// <param name="h">
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </param>
        public static ScaleFilter ScaleFilter(this ImageMap imageMap, Action<FFmpegExpression> w, Action<FFmpegExpression> h)
            => new ScaleFilter(imageMap).Width(w).Height(h);

        /// <summary>
        /// The filter accepts the following options, or any of the options supported by the libswscale scaler.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="w">
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </param>
        /// <param name="h">
        /// Set the output video dimension expression. Default value is the input dimension.<br></br>
        /// If the width or w value is 0, the input width is used for the output.If the height or h value is 0, the input height is used for the output.<br></br>
        /// If one and only one of the values is -n with n >= 1, the scale filter will use a value that maintains the aspect ratio of the input image, calculated from the other specified dimension. After that it will, however, make sure that the calculated dimension is divisible by n and adjust the value if necessary.<br></br>
        /// If both values are -n with n >= 1, the behavior will be identical to both values being set to 0 as previously detailed.
        /// </param>
        public static ScaleFilter ScaleFilter(this ImageMap imageMap, string w, string h)
            => new ScaleFilter(imageMap).Width(w).Height(h);

        /// <summary>
        /// The filter accepts the following options, or any of the options supported by the libswscale scaler.
        /// </summary>
        public static ScaleFilter ScaleFilter(this ImageMap input0, ScaleFilterConfig config)
        {
            var result = new ScaleFilter(input0);
            if (!string.IsNullOrWhiteSpace(config?.Width)) result.Width(config.Width);
            if (!string.IsNullOrWhiteSpace(config?.Height)) result.Height(config.Height);
            if (config?.Flags != null) result.Flags(config.Flags.Value);
            if (config?.Interl != null) result.Interl(config.Interl.Value);
            if (config?.InColorMatrix != null) result.InColorMatrix(config.InColorMatrix);
            if (config?.OutColorMatrix != null) result.OutColorMatrix(config.OutColorMatrix);
            if (config?.InRange != null) result.InRange(config.InRange.Value);
            if (config?.OutRange != null) result.OutRange(config.OutRange.Value);
            //if (config?.in_v_chr_pos != null) result.in_v_chr_pos(config.in_v_chr_pos.Value);
            //if (config?.in_h_chr_pos != null) result.in_h_chr_pos(config.in_h_chr_pos.Value);
            //if (config?.out_v_chr_pos != null) result.out_v_chr_pos(config.out_v_chr_pos.Value);
            //if (config?.out_h_chr_pos != null) result.out_h_chr_pos(config.out_h_chr_pos.Value);
            if (config?.ForceOriginalAspectRatio != null) result.ForceOriginalAspectRatio(config.ForceOriginalAspectRatio.Value);
            if (config?.ForceDivisibleBy != null) result.ForceDivisibleBy(config.ForceDivisibleBy.Value);
            if (config?.Param0 != null) result.Param0(config.Param0.Value);
            if (config?.Param1 != null) result.Param1(config.Param1.Value);
            //if (config?.NbSlices != null) result.nb_slices(config.NbSlices.Value);
            if (config?.Eval != null) result.Eval(config.Eval.Value);
            return result;
        }
    }

    public class ScaleFilterConfig
    {
        /// <summary>
        ///  Output video width
        /// </summary>
        public string Width { get; set; }
        /// <summary>
        ///  Output video height
        /// </summary>
        public string Height { get; set; }
        /// <summary>
        ///  Flags to pass to libswscale (default "bilinear")
        /// </summary>
        public SwsFlags? Flags { get; set; }
        /// <summary>
        ///  set interlacing (default false)
        /// </summary>
        public ScaleInterl? Interl { get; set; }
        /// <summary>
        ///  set input YCbCr type (default "auto")
        /// </summary>
        public ScaleColorMatrix InColorMatrix { get; set; }
        /// <summary>
        ///  set output YCbCr type
        /// </summary>
        public ScaleColorMatrix OutColorMatrix { get; set; }
        /// <summary>
        ///  set input color range (from 0 to 2) (default auto)
        /// </summary>
        public ScaleRange? InRange { get; set; }
        /// <summary>
        ///  set output color range (from 0 to 2) (default auto)
        /// </summary>
        public ScaleRange? OutRange { get; set; }
        ///// <summary>
        /////  input vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
        ///// </summary>
        //public int? in_v_chr_pos { get; set; }
        ///// <summary>
        /////  input horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
        ///// </summary>
        //public int? in_h_chr_pos { get; set; }
        ///// <summary>
        /////  output vertical chroma position in luma grid/256 (from -513 to 512) (default -513)
        ///// </summary>
        //public int? out_v_chr_pos { get; set; }
        ///// <summary>
        /////  output horizontal chroma position in luma grid/256 (from -513 to 512) (default -513)
        ///// </summary>
        //public int? out_h_chr_pos { get; set; }
        /// <summary>
        ///  decrease or increase w/h if necessary to keep the original AR (from 0 to 2) (default disable)
        /// </summary>
        public ScaleAspectRatio? ForceOriginalAspectRatio { get; set; }
        /// <summary>
        ///  enforce that the output resolution is divisible by a defined integer when force_original_aspect_ratio is used (from 1 to 256) (default 1)
        /// </summary>
        public int? ForceDivisibleBy { get; set; }
        /// <summary>
        ///  Scaler param 0 (from INT_MIN to INT_MAX) (default 123456)
        /// </summary>
        public double? Param0 { get; set; }
        /// <summary>
        ///  Scaler param 1 (from INT_MIN to INT_MAX) (default 123456)
        /// </summary>
        public double? Param1 { get; set; }
        ///// <summary>
        /////  set the number of slices (debug purpose only) (from 0 to INT_MAX) (default 0)
        ///// </summary>
        //public int? NbSlices { get; set; }
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default init)
        /// </summary>
        public ScaleEval? Eval { get; set; }
    }

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

    public enum ScaleRange
    {
        auto,
        unknown,
        jpeg,
        full,
        pc,
        mpeg,
        limited,
        tv
    }
}