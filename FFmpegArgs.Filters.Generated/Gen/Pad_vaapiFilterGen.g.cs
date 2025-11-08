namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. pad_vaapi         V-&gt;V       Pad the input video.
    /// </summary>
    public class Pad_vaapiFilterGen : ImageToImageFilter
    {
        internal Pad_vaapiFilterGen(ImageMap input) : base("pad_vaapi", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the pad area width (default &quot;iw&quot;)
        /// </summary>
        public Pad_vaapiFilterGen width(String width) => this.SetOption("width", width.ToString());
        /// <summary>
        ///  set the pad area height (default &quot;ih&quot;)
        /// </summary>
        public Pad_vaapiFilterGen height(String height) => this.SetOption("height", height.ToString());
        /// <summary>
        ///  set the x offset for the input image position (default &quot;0&quot;)
        /// </summary>
        public Pad_vaapiFilterGen x(String x) => this.SetOption("x", x.ToString());
        /// <summary>
        ///  set the y offset for the input image position (default &quot;0&quot;)
        /// </summary>
        public Pad_vaapiFilterGen y(String y) => this.SetOption("y", y.ToString());
        /// <summary>
        ///  set the color of the padded area border (default &quot;black&quot;)
        /// </summary>
        public Pad_vaapiFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  pad to fit an aspect instead of a resolution (from 0 to 32767) (default 0/1)
        /// </summary>
        public Pad_vaapiFilterGen aspect(Rational aspect) => this.SetOption("aspect", aspect.Check(0, 32767));
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Pad the input video.
        /// </summary>
        public static Pad_vaapiFilterGen Pad_vaapiFilterGen(this ImageMap input0) => new Pad_vaapiFilterGen(input0);
    }
}