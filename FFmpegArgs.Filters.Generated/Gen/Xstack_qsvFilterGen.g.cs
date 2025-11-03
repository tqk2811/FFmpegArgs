namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. xstack_qsv        N-&gt;V       &quot;Quick Sync Video&quot; xstack
    /// </summary>
    public class Xstack_qsvFilterGen : ImageToImageFilter
    {
        internal Xstack_qsvFilterGen(params ImageMap[] inputs) : base("xstack_qsv", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set number of inputs (from 2 to 65535) (default 2)
        /// </summary>
        public Xstack_qsvFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 2, 65535);
        /// <summary>
        ///  Force termination when the shortest input terminates (default false)
        /// </summary>
        public Xstack_qsvFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  Set custom layout
        /// </summary>
        public Xstack_qsvFilterGen layout(String layout) => this.SetOption("layout", layout.ToStringInv());
        /// <summary>
        ///  set fixed size grid layout
        /// </summary>
        public Xstack_qsvFilterGen grid(Size grid) => this.SetOption("grid", Inv($"{grid.Width}x{grid.Height}"));
        /// <summary>
        ///  set tile size in grid layout
        /// </summary>
        public Xstack_qsvFilterGen grid_tile_size(Size grid_tile_size) => this.SetOption("grid_tile_size", Inv($"{grid_tile_size.Width}x{grid_tile_size.Height}"));
        /// <summary>
        ///  Set the color for unused pixels (default &quot;none&quot;)
        /// </summary>
        public Xstack_qsvFilterGen fill(String fill) => this.SetOption("fill", fill.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// &quot;Quick Sync Video&quot; xstack
        /// </summary>
        public static Xstack_qsvFilterGen Xstack_qsvFilterGen(this ImageMap input) => new Xstack_qsvFilterGen(input);
    }
}