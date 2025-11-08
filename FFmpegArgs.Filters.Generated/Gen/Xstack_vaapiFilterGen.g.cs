namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. xstack_vaapi      N-&gt;V       &quot;VA-API&quot; xstack
    /// </summary>
    public class Xstack_vaapiFilterGen : ImageToImageFilter
    {
        internal Xstack_vaapiFilterGen(params ImageMap[] inputs) : base("xstack_vaapi", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set number of inputs (from 2 to 65535) (default 2)
        /// </summary>
        public Xstack_vaapiFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 2, 65535);
        /// <summary>
        ///  Force termination when the shortest input terminates (default false)
        /// </summary>
        public Xstack_vaapiFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  Set custom layout
        /// </summary>
        public Xstack_vaapiFilterGen layout(String layout) => this.SetOption("layout", layout.ToString());
        /// <summary>
        ///  set fixed size grid layout
        /// </summary>
        public Xstack_vaapiFilterGen grid(Size grid) => this.SetOption("grid", $"{grid.Width}x{grid.Height}");
        /// <summary>
        ///  set tile size in grid layout
        /// </summary>
        public Xstack_vaapiFilterGen grid_tile_size(Size grid_tile_size) => this.SetOption("grid_tile_size", $"{grid_tile_size.Width}x{grid_tile_size.Height}");
        /// <summary>
        ///  Set the color for unused pixels (default &quot;none&quot;)
        /// </summary>
        public Xstack_vaapiFilterGen fill(String fill) => this.SetOption("fill", fill.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// &quot;VA-API&quot; xstack
        /// </summary>
        public static Xstack_vaapiFilterGen Xstack_vaapiFilterGen(this ImageMap input) => new Xstack_vaapiFilterGen(input);
    }
}