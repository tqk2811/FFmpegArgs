namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... select            V-&gt;N       Select video frames to pass in output.
    /// </summary>
    public class SelectFilterGen : ImageToImageFilter
    {
        internal SelectFilterGen(ImageMap input, int outputCount) : base("select", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  set an expression to use for selecting frames (default &quot;1&quot;)
        /// </summary>
        public SelectFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
        /// <summary>
        ///  set the number of outputs (from 1 to INT_MAX) (default 1)
        /// </summary>
        public SelectFilterGen outputs(int outputs) => this.SetOptionRange("outputs", outputs, 1, INT_MAX);
        /// <summary>
        ///  set the number of outputs (from 1 to INT_MAX) (default 1)
        /// </summary>
        public SelectFilterGen n(int n) => this.SetOptionRange("n", n, 1, INT_MAX);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Select video frames to pass in output.
        /// </summary>
        public static SelectFilterGen SelectFilterGen(this ImageMap input0, int outputCount) => new SelectFilterGen(input0, outputCount);
    }
}