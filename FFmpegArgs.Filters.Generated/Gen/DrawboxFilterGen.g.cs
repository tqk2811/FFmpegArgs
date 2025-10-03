namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.C drawbox           V-&gt;V       Draw a colored box on the input video.
    /// </summary>
    public class DrawboxFilterGen : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        internal DrawboxFilterGen(ImageMap input) : base("drawbox", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set horizontal position of the left box edge (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen x(String x) => this.SetOption("x", x.ToString());
        /// <summary>
        ///  set vertical position of the top box edge (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen y(String y) => this.SetOption("y", y.ToString());
        /// <summary>
        ///  set width of the box (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen width(String width) => this.SetOption("width", width.ToString());
        /// <summary>
        ///  set height of the box (default &quot;0&quot;)
        /// </summary>
        public DrawboxFilterGen height(String height) => this.SetOption("height", height.ToString());
        /// <summary>
        ///  set color of the box (default &quot;black&quot;)
        /// </summary>
        public DrawboxFilterGen color(String color) => this.SetOption("color", color.ToString());
        /// <summary>
        ///  set the box thickness (default &quot;3&quot;)
        /// </summary>
        public DrawboxFilterGen thickness(String thickness) => this.SetOption("thickness", thickness.ToString());
        /// <summary>
        ///  replace color &amp; alpha (default false)
        /// </summary>
        public DrawboxFilterGen replace(bool replace) => this.SetOption("replace", replace.ToFFmpegFlag());
        /// <summary>
        ///  use datas from bounding box in side data
        /// </summary>
        public DrawboxFilterGen box_source(String box_source) => this.SetOption("box_source", box_source.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static DrawboxFilterGen DrawboxFilterGen(this ImageMap input0) => new DrawboxFilterGen(input0);
    }
}