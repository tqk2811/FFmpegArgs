namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S. xstack            N-&gt;V       Stack video inputs into custom layout.
    /// </summary>
    public class XstackFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal XstackFilterGen(params ImageMap[] inputs) : base("xstack", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set number of inputs (from 2 to INT_MAX) (default 2)
        /// </summary>
        public XstackFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 2, INT_MAX);
        /// <summary>
        ///  set custom layout
        /// </summary>
        public XstackFilterGen layout(String layout) => this.SetOption("layout", layout.ToString());
        /// <summary>
        ///  set fixed size grid layout
        /// </summary>
        public XstackFilterGen grid(Size grid) => this.SetOption("grid", Inv($"{grid.Width}x{grid.Height}"));
        /// <summary>
        ///  force termination when the shortest input terminates (default false)
        /// </summary>
        public XstackFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  set the color for unused pixels (default &quot;none&quot;)
        /// </summary>
        public XstackFilterGen fill(String fill) => this.SetOption("fill", fill.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Stack video inputs into custom layout.
        /// </summary>
        public static XstackFilterGen XstackFilterGen(this ImageMap input) => new XstackFilterGen(input);
    }
}