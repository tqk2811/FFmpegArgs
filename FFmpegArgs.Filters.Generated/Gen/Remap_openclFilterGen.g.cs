namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... remap_opencl      VVV-&gt;V     Remap pixels using OpenCL.
    /// </summary>
    public class Remap_openclFilterGen : ImageToImageFilter
    {
        internal Remap_openclFilterGen(params ImageMap[] inputs) : base("remap_opencl", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set interpolation method (from 0 to 1) (default linear)
        /// </summary>
        public Remap_openclFilterGen interp(Remap_openclFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the color of the unmapped pixels (default &quot;black&quot;)
        /// </summary>
        public Remap_openclFilterGen fill(Color fill) => this.SetOption("fill", fill.ToHexStringRGBA());
    }

    /// <summary>
    ///  set interpolation method (from 0 to 1) (default linear)
    /// </summary>
    public enum Remap_openclFilterGenInterp
    {
        /// <summary>
        /// near            0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("near")]
        near = 0,
        /// <summary>
        /// linear          1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Remap pixels using OpenCL.
        /// </summary>
        public static Remap_openclFilterGen Remap_openclFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new Remap_openclFilterGen(input0, input1, input2);
    }
}