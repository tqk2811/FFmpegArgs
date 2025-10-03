namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC rotate            V-&gt;V       Rotate the input image.
    /// </summary>
    public class RotateFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal RotateFilterGen(ImageMap input) : base("rotate", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set angle (in radians) (default &quot;0&quot;)
        /// </summary>
        public RotateFilterGen angle(String angle) => this.SetOption("angle", angle.ToString());
        /// <summary>
        ///  set output width expression (default &quot;iw&quot;)
        /// </summary>
        public RotateFilterGen out_w(ExpressionValue out_w) => this.SetOption("out_w", (string)out_w);
        /// <summary>
        ///  set output width expression (default &quot;iw&quot;)
        /// </summary>
        public RotateFilterGen ow(ExpressionValue ow) => this.SetOption("ow", (string)ow);
        /// <summary>
        ///  set output height expression (default &quot;ih&quot;)
        /// </summary>
        public RotateFilterGen out_h(ExpressionValue out_h) => this.SetOption("out_h", (string)out_h);
        /// <summary>
        ///  set output height expression (default &quot;ih&quot;)
        /// </summary>
        public RotateFilterGen oh(ExpressionValue oh) => this.SetOption("oh", (string)oh);
        /// <summary>
        ///  set background fill color (default &quot;black&quot;)
        /// </summary>
        public RotateFilterGen fillcolor(String fillcolor) => this.SetOption("fillcolor", fillcolor.ToString());
        /// <summary>
        ///  set background fill color (default &quot;black&quot;)
        /// </summary>
        public RotateFilterGen c(String c) => this.SetOption("c", c.ToString());
        /// <summary>
        ///  use bilinear interpolation (default true)
        /// </summary>
        public RotateFilterGen bilinear(bool bilinear) => this.SetOption("bilinear", bilinear.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Rotate the input image.
        /// </summary>
        public static RotateFilterGen RotateFilterGen(this ImageMap input0) => new RotateFilterGen(input0);
    }
}