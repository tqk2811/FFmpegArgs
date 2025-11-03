namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS curves            V-&gt;V       Adjust components curves.
    /// </summary>
    public class CurvesFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal CurvesFilterGen(ImageMap input) : base("curves", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select a color curves preset (from 0 to 10) (default none)
        /// </summary>
        public CurvesFilterGen preset(CurvesFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set master points coordinates
        /// </summary>
        public CurvesFilterGen master(String master) => this.SetOption("master", master.ToStringInv());
        /// <summary>
        ///  set red points coordinates
        /// </summary>
        public CurvesFilterGen red(String red) => this.SetOption("red", red.ToStringInv());
        /// <summary>
        ///  set green points coordinates
        /// </summary>
        public CurvesFilterGen green(String green) => this.SetOption("green", green.ToStringInv());
        /// <summary>
        ///  set blue points coordinates
        /// </summary>
        public CurvesFilterGen blue(String blue) => this.SetOption("blue", blue.ToStringInv());
        /// <summary>
        ///  set points coordinates for all components
        /// </summary>
        public CurvesFilterGen all(String all) => this.SetOption("all", all.ToStringInv());
        /// <summary>
        ///  set Photoshop curves file name
        /// </summary>
        public CurvesFilterGen psfile(String psfile) => this.SetOption("psfile", psfile.ToStringInv());
        /// <summary>
        ///  save Gnuplot script of the curves in specified file
        /// </summary>
        public CurvesFilterGen plot(String plot) => this.SetOption("plot", plot.ToStringInv());
        /// <summary>
        ///  specify the kind of interpolation (from 0 to 1) (default natural)
        /// </summary>
        public CurvesFilterGen interp(CurvesFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  select a color curves preset (from 0 to 10) (default none)
    /// </summary>
    public enum CurvesFilterGenPreset
    {
        /// <summary>
        /// none            0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// color_negative  1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("color_negative")]
        color_negative = 1,
        /// <summary>
        /// cross_process   2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cross_process")]
        cross_process = 2,
        /// <summary>
        /// darker          3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("darker")]
        darker = 3,
        /// <summary>
        /// increase_contrast 4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("increase_contrast")]
        increase_contrast = 4,
        /// <summary>
        /// lighter         5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lighter")]
        lighter = 5,
        /// <summary>
        /// linear_contrast 6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear_contrast")]
        linear_contrast = 6,
        /// <summary>
        /// medium_contrast 7            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("medium_contrast")]
        medium_contrast = 7,
        /// <summary>
        /// negative        8            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("negative")]
        negative = 8,
        /// <summary>
        /// strong_contrast 9            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("strong_contrast")]
        strong_contrast = 9,
        /// <summary>
        /// vintage         10           ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vintage")]
        vintage = 10
    }

    /// <summary>
    ///  specify the kind of interpolation (from 0 to 1) (default natural)
    /// </summary>
    public enum CurvesFilterGenInterp
    {
        /// <summary>
        /// natural         0            ..FV.....T. natural cubic spline
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("natural")]
        natural = 0,
        /// <summary>
        /// pchip           1            ..FV.....T. monotonically cubic interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pchip")]
        pchip = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Adjust components curves.
        /// </summary>
        public static CurvesFilterGen CurvesFilterGen(this ImageMap input0) => new CurvesFilterGen(input0);
    }
}