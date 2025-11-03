namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... zoompan           V-&gt;V       Apply Zoom &amp; Pan effect.
    /// </summary>
    public class ZoompanFilterGen : ImageToImageFilter
    {
        internal ZoompanFilterGen(ImageMap input) : base("zoompan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the zoom expression (default &quot;1&quot;)
        /// </summary>
        public ZoompanFilterGen zoom(ExpressionValue zoom) => this.SetOption("zoom", (string)zoom);
        /// <summary>
        ///  set the x expression (default &quot;0&quot;)
        /// </summary>
        public ZoompanFilterGen x(ExpressionValue x) => this.SetOption("x", (string)x);
        /// <summary>
        ///  set the y expression (default &quot;0&quot;)
        /// </summary>
        public ZoompanFilterGen y(ExpressionValue y) => this.SetOption("y", (string)y);
        /// <summary>
        ///  set the duration expression (default &quot;90&quot;)
        /// </summary>
        public ZoompanFilterGen d(ExpressionValue d) => this.SetOption("d", (string)d);
        /// <summary>
        ///  set the output image size (default &quot;hd720&quot;)
        /// </summary>
        public ZoompanFilterGen s(Size s) => this.SetOption("s", Inv($"{s.Width}x{s.Height}"));
        /// <summary>
        ///  set the output framerate (default &quot;25&quot;)
        /// </summary>
        public ZoompanFilterGen fps(Rational fps) => this.SetOption("fps", fps.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Zoom &amp; Pan effect.
        /// </summary>
        public static ZoompanFilterGen ZoompanFilterGen(this ImageMap input0) => new ZoompanFilterGen(input0);
    }
}