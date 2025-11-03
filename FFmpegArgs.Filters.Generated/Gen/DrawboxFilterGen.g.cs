namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. drawbox           V-&gt;V       Draw a colored box on the input video.
    /// </summary>
    public class DrawboxFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal DrawboxFilterGen(ImageMap input) : base("drawbox", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set horizontal position of the left box edge (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen x(String x) => this.SetOption("x", x.ToStringInv());
        /// <summary>
        ///  set vertical position of the top box edge (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen y(String y) => this.SetOption("y", y.ToStringInv());
        /// <summary>
        ///  set width of the box (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen width(String width) => this.SetOption("width", width.ToStringInv());
        /// <summary>
        ///  set height of the box (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen height(String height) => this.SetOption("height", height.ToStringInv());
        /// <summary>
        ///  set color of the box (default &quot;black&quot;)
        /// </summary>
        public DrawboxFilterGen color(String color) => this.SetOption("color", color.ToStringInv());
        /// <summary>
        ///  set the box thickness (default &quot;3&quot;)
        /// </summary>
        public DrawboxFilterGen thickness(String thickness) => this.SetOption("thickness", thickness.ToStringInv());
        /// <summary>
        ///  replace color &amp; alpha (default false)
        /// </summary>
        public DrawboxFilterGen replace(bool replace) => this.SetOption("replace", replace.ToFFmpegFlag());
        /// <summary>
        ///  use data from bounding box in side data
        /// </summary>
        public DrawboxFilterGen box_source(String box_source) => this.SetOption("box_source", box_source.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static DrawboxFilterGen DrawboxFilterGen(this ImageMap input0) => new DrawboxFilterGen(input0);
    }
}