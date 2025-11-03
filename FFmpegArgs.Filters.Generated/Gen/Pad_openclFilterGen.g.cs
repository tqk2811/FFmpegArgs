namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. pad_opencl        V-&gt;V       Pad the input video.
    /// </summary>
    public class Pad_openclFilterGen : ImageToImageFilter
    {
        internal Pad_openclFilterGen(ImageMap input) : base("pad_opencl", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the pad area width (default &quot;iw&quot;)
        /// </summary>
        public Pad_openclFilterGen width(String width) => this.SetOption("width", width.ToStringInv());
        /// <summary>
        ///  set the pad area height (default &quot;ih&quot;)
        /// </summary>
        public Pad_openclFilterGen height(String height) => this.SetOption("height", height.ToStringInv());
        /// <summary>
        ///  set the x offset for the input image position (default &quot;0&quot;)
        /// </summary>
        public Pad_openclFilterGen x(String x) => this.SetOption("x", x.ToStringInv());
        /// <summary>
        ///  set the y offset for the input image position (default &quot;0&quot;)
        /// </summary>
        public Pad_openclFilterGen y(String y) => this.SetOption("y", y.ToStringInv());
        /// <summary>
        ///  set the color of the padded area border (default &quot;black&quot;)
        /// </summary>
        public Pad_openclFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  pad to fit an aspect instead of a resolution (from 0 to 32767) (default 0/1)
        /// </summary>
        public Pad_openclFilterGen aspect(Rational aspect) => this.SetOption("aspect", aspect.Check(0, 32767));
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Pad the input video.
        /// </summary>
        public static Pad_openclFilterGen Pad_openclFilterGen(this ImageMap input0) => new Pad_openclFilterGen(input0);
    }
}