namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. drawbox_vaapi     V-&gt;V       Draw a colored box on the input video.
    /// </summary>
    public class Drawbox_vaapiFilterGen : ImageToImageFilter
    {
        internal Drawbox_vaapiFilterGen(ImageMap input) : base("drawbox_vaapi", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set horizontal position of the left box edge (default &quot;0&quot;)
        /// </summary>
        public Drawbox_vaapiFilterGen x(String x) => this.SetOption("x", x.ToStringInv());
        /// <summary>
        ///  set vertical position of the top box edge (default &quot;0&quot;)
        /// </summary>
        public Drawbox_vaapiFilterGen y(String y) => this.SetOption("y", y.ToStringInv());
        /// <summary>
        ///  set width of the box (default &quot;0&quot;)
        /// </summary>
        public Drawbox_vaapiFilterGen width(String width) => this.SetOption("width", width.ToStringInv());
        /// <summary>
        ///  set height of the box (default &quot;0&quot;)
        /// </summary>
        public Drawbox_vaapiFilterGen height(String height) => this.SetOption("height", height.ToStringInv());
        /// <summary>
        ///  set color of the box (default &quot;black&quot;)
        /// </summary>
        public Drawbox_vaapiFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  set the box thickness (default &quot;3&quot;)
        /// </summary>
        public Drawbox_vaapiFilterGen thickness(String thickness) => this.SetOption("thickness", thickness.ToStringInv());
        /// <summary>
        ///  replace color (default false)
        /// </summary>
        public Drawbox_vaapiFilterGen replace(bool replace) => this.SetOption("replace", replace.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static Drawbox_vaapiFilterGen Drawbox_vaapiFilterGen(this ImageMap input0) => new Drawbox_vaapiFilterGen(input0);
    }
}