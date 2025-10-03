namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... tiltandshift      V-&gt;V       Generate a tilt-and-shift&#39;d video.
    /// </summary>
    public class TiltandshiftFilterGen : ImageToImageFilter
    {
        internal TiltandshiftFilterGen(ImageMap input) : base("tiltandshift", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Tilt the video horizontally while shifting (from 0 to 1) (default 1)
        /// </summary>
        public TiltandshiftFilterGen tilt(int tilt) => this.SetOptionRange("tilt", tilt, 0, 1);
        /// <summary>
        ///  Action at the start of input (from 0 to 3) (default none)
        /// </summary>
        public TiltandshiftFilterGen start(TiltandshiftFilterGenStart start) => this.SetOption("start", start.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Action at the end of input (from 0 to 3) (default none)
        /// </summary>
        public TiltandshiftFilterGen end(TiltandshiftFilterGenEnd end) => this.SetOption("end", end.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Number of columns to hold at the start of the video (from 0 to INT_MAX) (default 0)
        /// </summary>
        public TiltandshiftFilterGen hold(int hold) => this.SetOptionRange("hold", hold, 0, INT_MAX);
        /// <summary>
        ///  Number of columns to pad at the end of the video (from 0 to INT_MAX) (default 0)
        /// </summary>
        public TiltandshiftFilterGen pad(int pad) => this.SetOptionRange("pad", pad, 0, INT_MAX);
    }

    /// <summary>
    ///  Action at the start of input (from 0 to 3) (default none)
    /// </summary>
    public enum TiltandshiftFilterGenStart
    {
        /// <summary>
        /// none            0            ...V....... Start immediately (default)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// frame           1            ...V....... Use the first frames
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1,
        /// <summary>
        /// black           2            ...V....... Fill with black
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("black")]
        black = 2
    }

    /// <summary>
    ///  Action at the end of input (from 0 to 3) (default none)
    /// </summary>
    public enum TiltandshiftFilterGenEnd
    {
        /// <summary>
        /// none            0            ...V....... Do not pad at the end (default)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// frame           1            ...V....... Use the last frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1,
        /// <summary>
        /// black           2            ...V....... Fill with black
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("black")]
        black = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate a tilt-and-shift&#39;d video.
        /// </summary>
        public static TiltandshiftFilterGen TiltandshiftFilterGen(this ImageMap input0) => new TiltandshiftFilterGen(input0);
    }
}