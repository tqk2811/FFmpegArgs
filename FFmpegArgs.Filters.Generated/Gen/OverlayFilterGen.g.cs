namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC overlay           VV-&gt;V      Overlay a video source on top of the input.
    /// </summary>
    public class OverlayFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal OverlayFilterGen(params ImageMap[] inputs) : base("overlay", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the x expression (default &quot;0&quot;)
        /// </summary>
        public OverlayFilterGen x(ExpressionValue x) => this.SetOption("x", (string)x);
        /// <summary>
        ///  set the y expression (default &quot;0&quot;)
        /// </summary>
        public OverlayFilterGen y(ExpressionValue y) => this.SetOption("y", (string)y);
        /// <summary>
        ///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
        /// </summary>
        public OverlayFilterGen eof_action(OverlayFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default frame)
        /// </summary>
        public OverlayFilterGen eval(OverlayFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  force termination when the shortest input terminates (default false)
        /// </summary>
        public OverlayFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  set output format (from 0 to 8) (default yuv420)
        /// </summary>
        public OverlayFilterGen format(OverlayFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  repeat overlay of the last overlay frame (default true)
        /// </summary>
        public OverlayFilterGen repeatlast(bool repeatlast) => this.SetOption("repeatlast", repeatlast.ToFFmpegFlag());
        /// <summary>
        ///  alpha format (from 0 to 1) (default straight)
        /// </summary>
        public OverlayFilterGen alpha(OverlayFilterGenAlpha alpha) => this.SetOption("alpha", alpha.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
    /// </summary>
    public enum OverlayFilterGenEof_action
    {
        /// <summary>
        /// repeat          0            ..FV....... Repeat the previous frame.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("repeat")]
        repeat = 0,
        /// <summary>
        /// endall          1            ..FV....... End both streams.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("endall")]
        endall = 1,
        /// <summary>
        /// pass            2            ..FV....... Pass through the main input.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pass")]
        pass = 2
    }

    /// <summary>
    ///  specify when to evaluate expressions (from 0 to 1) (default frame)
    /// </summary>
    public enum OverlayFilterGenEval
    {
        /// <summary>
        /// init            0            ..FV....... eval expressions once during initialization
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("init")]
        init = 0,
        /// <summary>
        /// frame           1            ..FV....... eval expressions per-frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1
    }

    /// <summary>
    ///  set output format (from 0 to 8) (default yuv420)
    /// </summary>
    public enum OverlayFilterGenFormat
    {
        /// <summary>
        /// yuv420          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv420")]
        yuv420 = 0,
        /// <summary>
        /// yuv420p10       1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv420p10")]
        yuv420p10 = 1,
        /// <summary>
        /// yuv422          2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv422")]
        yuv422 = 2,
        /// <summary>
        /// yuv422p10       3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv422p10")]
        yuv422p10 = 3,
        /// <summary>
        /// yuv444          4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv444")]
        yuv444 = 4,
        /// <summary>
        /// yuv444p10       5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("yuv444p10")]
        yuv444p10 = 5,
        /// <summary>
        /// rgb             6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rgb")]
        rgb = 6,
        /// <summary>
        /// gbrp            7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gbrp")]
        gbrp = 7,
        /// <summary>
        /// auto            8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 8
    }

    /// <summary>
    ///  alpha format (from 0 to 1) (default straight)
    /// </summary>
    public enum OverlayFilterGenAlpha
    {
        /// <summary>
        /// straight        0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("straight")]
        straight = 0,
        /// <summary>
        /// premultiplied   1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("premultiplied")]
        premultiplied = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Overlay a video source on top of the input.
        /// </summary>
        public static OverlayFilterGen OverlayFilterGen(this ImageMap input0, ImageMap input1) => new OverlayFilterGen(input0, input1);
    }
}