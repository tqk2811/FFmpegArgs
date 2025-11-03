namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS lut1d             V-&gt;V       Adjust colors using a 1D LUT.
    /// </summary>
    public class Lut1dFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal Lut1dFilterGen(ImageMap input) : base("lut1d", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set 1D LUT file name
        /// </summary>
        public Lut1dFilterGen file(String file) => this.SetOption("file", file.ToStringInv());
        /// <summary>
        ///  select interpolation mode (from 0 to 4) (default linear)
        /// </summary>
        public Lut1dFilterGen interp(Lut1dFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  select interpolation mode (from 0 to 4) (default linear)
    /// </summary>
    public enum Lut1dFilterGenInterp
    {
        /// <summary>
        /// nearest         0            ..FV.....T. use values from the nearest defined points
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nearest")]
        nearest = 0,
        /// <summary>
        /// linear          1            ..FV.....T. use values from the linear interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 1,
        /// <summary>
        /// cosine          3            ..FV.....T. use values from the cosine interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cosine")]
        cosine = 3,
        /// <summary>
        /// cubic           2            ..FV.....T. use values from the cubic interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cubic")]
        cubic = 2,
        /// <summary>
        /// spline          4            ..FV.....T. use values from the spline interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("spline")]
        spline = 4
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Adjust colors using a 1D LUT.
        /// </summary>
        public static Lut1dFilterGen Lut1dFilterGen(this ImageMap input0) => new Lut1dFilterGen(input0);
    }
}