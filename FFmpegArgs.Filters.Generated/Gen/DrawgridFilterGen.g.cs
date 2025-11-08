namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. drawgrid          V-&gt;V       Draw a colored grid on the input video.
    /// </summary>
    public class DrawgridFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal DrawgridFilterGen(ImageMap input) : base("drawgrid", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set horizontal offset (default &quot;0&quot;)
        /// </summary>
        public DrawgridFilterGen x(String x) => this.SetOption("x", x.ToString());
        /// <summary>
        ///  set vertical offset (default &quot;0&quot;)
        /// </summary>
        public DrawgridFilterGen y(String y) => this.SetOption("y", y.ToString());
        /// <summary>
        ///  set width of grid cell (default &quot;0&quot;)
        /// </summary>
        public DrawgridFilterGen width(String width) => this.SetOption("width", width.ToString());
        /// <summary>
        ///  set height of grid cell (default &quot;0&quot;)
        /// </summary>
        public DrawgridFilterGen height(String height) => this.SetOption("height", height.ToString());
        /// <summary>
        ///  set color of the grid (default &quot;black&quot;)
        /// </summary>
        public DrawgridFilterGen color(String color) => this.SetOption("color", color.ToString());
        /// <summary>
        ///  set grid line thickness (default &quot;1&quot;)
        /// </summary>
        public DrawgridFilterGen thickness(String thickness) => this.SetOption("thickness", thickness.ToString());
        /// <summary>
        ///  replace color &amp; alpha (default false)
        /// </summary>
        public DrawgridFilterGen replace(bool replace) => this.SetOption("replace", replace.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Draw a colored grid on the input video.
        /// </summary>
        public static DrawgridFilterGen DrawgridFilterGen(this ImageMap input0) => new DrawgridFilterGen(input0);
    }
}