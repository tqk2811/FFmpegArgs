namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC shear             V-&gt;V       Shear transform the input image.
    /// </summary>
    public class ShearFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ShearFilterGen(ImageMap input) : base("shear", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set x shear factor (from -2 to 2) (default 0)
        /// </summary>
        public ShearFilterGen shx(float shx) => this.SetOptionRange("shx", shx, -2, 2);
        /// <summary>
        ///  set y shear factor (from -2 to 2) (default 0)
        /// </summary>
        public ShearFilterGen shy(float shy) => this.SetOptionRange("shy", shy, -2, 2);
        /// <summary>
        ///  set background fill color (default &quot;black&quot;)
        /// </summary>
        public ShearFilterGen fillcolor(String fillcolor) => this.SetOption("fillcolor", fillcolor.ToString());
        /// <summary>
        ///  set background fill color (default &quot;black&quot;)
        /// </summary>
        public ShearFilterGen c(String c) => this.SetOption("c", c.ToString());
        /// <summary>
        ///  set interpolation (from 0 to 1) (default bilinear)
        /// </summary>
        public ShearFilterGen interp(ShearFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set interpolation (from 0 to 1) (default bilinear)
    /// </summary>
    public enum ShearFilterGenInterp
    {
        /// <summary>
        /// nearest         0            ..FV.....T. nearest neighbour
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nearest")]
        nearest = 0,
        /// <summary>
        /// bilinear        1            ..FV.....T. bilinear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Shear transform the input image.
        /// </summary>
        public static ShearFilterGen ShearFilterGen(this ImageMap input0) => new ShearFilterGen(input0);
    }
}