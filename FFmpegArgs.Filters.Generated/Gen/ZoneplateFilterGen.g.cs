namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S zoneplate         |-&gt;V       Generate zone-plate.
    /// </summary>
    public class ZoneplateFilterGen : SourceToImageFilter, ISliceThreading
    {
        internal ZoneplateFilterGen(IImageFilterGraph input) : base("zoneplate", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;320x240&quot;)
        /// </summary>
        public ZoneplateFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ZoneplateFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video duration (default -0.000001)
        /// </summary>
        public ZoneplateFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
        /// </summary>
        public ZoneplateFilterGen sar(Rational sar) => this.SetOption("sar", sar.Check(0, INT_MAX));
        /// <summary>
        ///  set LUT precision (from 4 to 16) (default 10)
        /// </summary>
        public ZoneplateFilterGen precision(int precision) => this.SetOptionRange("precision", precision, 4, 16);
        /// <summary>
        ///  set X-axis offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen xo(int xo) => this.SetOptionRange("xo", xo, INT_MIN, INT_MAX);
        /// <summary>
        ///  set Y-axis offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen yo(int yo) => this.SetOptionRange("yo", yo, INT_MIN, INT_MAX);
        /// <summary>
        ///  set T-axis offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen to(int to) => this.SetOptionRange("to", to, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 0-order phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen k0(int k0) => this.SetOptionRange("k0", k0, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 1-order X-axis phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kx(int kx) => this.SetOptionRange("kx", kx, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 1-order Y-axis phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen ky(int ky) => this.SetOptionRange("ky", ky, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 1-order T-axis phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kt(int kt) => this.SetOptionRange("kt", kt, INT_MIN, INT_MAX);
        /// <summary>
        ///  set X-axis*T-axis product phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kxt(int kxt) => this.SetOptionRange("kxt", kxt, INT_MIN, INT_MAX);
        /// <summary>
        ///  set Y-axis*T-axis product phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kyt(int kyt) => this.SetOptionRange("kyt", kyt, INT_MIN, INT_MAX);
        /// <summary>
        ///  set X-axis*Y-axis product phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kxy(int kxy) => this.SetOptionRange("kxy", kxy, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 2-order X-axis phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kx2(int kx2) => this.SetOptionRange("kx2", kx2, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 2-order Y-axis phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen ky2(int ky2) => this.SetOptionRange("ky2", ky2, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 2-order T-axis phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kt2(int kt2) => this.SetOptionRange("kt2", kt2, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 0-order U-color phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen ku(int ku) => this.SetOptionRange("ku", ku, INT_MIN, INT_MAX);
        /// <summary>
        ///  set 0-order V-color phase (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public ZoneplateFilterGen kv(int kv) => this.SetOptionRange("kv", kv, INT_MIN, INT_MAX);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate zone-plate.
        /// </summary>
        public static ZoneplateFilterGen ZoneplateFilterGen(this IImageFilterGraph input) => new ZoneplateFilterGen(input);
    }
}