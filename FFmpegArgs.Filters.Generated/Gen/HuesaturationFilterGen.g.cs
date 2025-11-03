namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS huesaturation     V-&gt;V       Apply hue-saturation-intensity adjustments.
    /// </summary>
    public class HuesaturationFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal HuesaturationFilterGen(ImageMap input) : base("huesaturation", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the hue shift (from -180 to 180) (default 0)
        /// </summary>
        public HuesaturationFilterGen hue(float hue) => this.SetOptionRange("hue", hue, -180, 180);
        /// <summary>
        ///  set the saturation shift (from -1 to 1) (default 0)
        /// </summary>
        public HuesaturationFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation, -1, 1);
        /// <summary>
        ///  set the intensity shift (from -1 to 1) (default 0)
        /// </summary>
        public HuesaturationFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity, -1, 1);
        /// <summary>
        ///  set colors range (default r+y+g+c+b+m+a)
        /// </summary>
        public HuesaturationFilterGen colors(HuesaturationFilterGenColors colors) => this.SetOption("colors", colors.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the filtering strength (from 0 to 100) (default 1)
        /// </summary>
        public HuesaturationFilterGen strength(float strength) => this.SetOptionRange("strength", strength, 0, 100);
        /// <summary>
        ///  set the red weight (from 0 to 1) (default 0.333)
        /// </summary>
        public HuesaturationFilterGen rw(float rw) => this.SetOptionRange("rw", rw, 0, 1);
        /// <summary>
        ///  set the green weight (from 0 to 1) (default 0.334)
        /// </summary>
        public HuesaturationFilterGen gw(float gw) => this.SetOptionRange("gw", gw, 0, 1);
        /// <summary>
        ///  set the blue weight (from 0 to 1) (default 0.333)
        /// </summary>
        public HuesaturationFilterGen bw(float bw) => this.SetOptionRange("bw", bw, 0, 1);
        /// <summary>
        ///  set the preserve lightness (default false)
        /// </summary>
        public HuesaturationFilterGen lightness(bool lightness) => this.SetOption("lightness", lightness.ToFFmpegFlag());
    }

    /// <summary>
    ///  set colors range (default r+y+g+c+b+m+a)
    /// </summary>
    public enum HuesaturationFilterGenColors
    {
        /// <summary>
        /// r                            ..FV.....T. set reds
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("r")]
        r,
        /// <summary>
        /// y                            ..FV.....T. set yellows
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("y")]
        y,
        /// <summary>
        /// g                            ..FV.....T. set greens
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("g")]
        g,
        /// <summary>
        /// c                            ..FV.....T. set cyans
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("c")]
        c,
        /// <summary>
        /// b                            ..FV.....T. set blues
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b,
        /// <summary>
        /// m                            ..FV.....T. set magentas
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("m")]
        m,
        /// <summary>
        /// a                            ..FV.....T. set all colors
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("a")]
        a
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply hue-saturation-intensity adjustments.
        /// </summary>
        public static HuesaturationFilterGen HuesaturationFilterGen(this ImageMap input0) => new HuesaturationFilterGen(input0);
    }
}