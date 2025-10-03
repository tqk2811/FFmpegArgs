namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... fps               V-&gt;V       Force constant framerate.
    /// </summary>
    public class FpsFilterGen : ImageToImageFilter
    {
        internal FpsFilterGen(ImageMap input) : base("fps", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  A string describing desired output framerate (default &quot;25&quot;)
        /// </summary>
        public FpsFilterGen fps(String fps) => this.SetOption("fps", fps.ToString());
        /// <summary>
        ///  Assume the first PTS should be this value. (from -DBL_MAX to DBL_MAX) (default DBL_MAX)
        /// </summary>
        public FpsFilterGen start_time(double start_time) => this.SetOptionRange("start_time", start_time, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  set rounding method for timestamps (from 0 to 5) (default near)
        /// </summary>
        public FpsFilterGen round(FpsFilterGenRound round) => this.SetOption("round", round.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  action performed for last frame (from 0 to 1) (default round)
        /// </summary>
        public FpsFilterGen eof_action(FpsFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set rounding method for timestamps (from 0 to 5) (default near)
    /// </summary>
    public enum FpsFilterGenRound
    {
        /// <summary>
        /// zero            0            ..FV....... round towards 0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("zero")]
        zero = 0,
        /// <summary>
        /// inf             1            ..FV....... round away from 0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("inf")]
        inf = 1,
        /// <summary>
        /// down            2            ..FV....... round towards -infty
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("down")]
        down = 2,
        /// <summary>
        /// up              3            ..FV....... round towards +infty
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("up")]
        up = 3,
        /// <summary>
        /// near            5            ..FV....... round to nearest
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("near")]
        near = 5
    }

    /// <summary>
    ///  action performed for last frame (from 0 to 1) (default round)
    /// </summary>
    public enum FpsFilterGenEof_action
    {
        /// <summary>
        /// round           0            ..FV....... round similar to other frames
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("round")]
        round = 0,
        /// <summary>
        /// pass            1            ..FV....... pass through last frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pass")]
        pass = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Force constant framerate.
        /// </summary>
        public static FpsFilterGen FpsFilterGen(this ImageMap input0) => new FpsFilterGen(input0);
    }
}