namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. hstack_vaapi      N-&gt;V       &quot;VA-API&quot; hstack
    /// </summary>
    public class Hstack_vaapiFilterGen : ImageToImageFilter
    {
        internal Hstack_vaapiFilterGen(params ImageMap[] inputs) : base("hstack_vaapi", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set number of inputs (from 2 to 65535) (default 2)
        /// </summary>
        public Hstack_vaapiFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 2, 65535);
        /// <summary>
        ///  Force termination when the shortest input terminates (default false)
        /// </summary>
        public Hstack_vaapiFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  Set output height (0 to use the height of input 0) (from 0 to 65535) (default 0)
        /// </summary>
        public Hstack_vaapiFilterGen height(int height) => this.SetOptionRange("height", height, 0, 65535);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// &quot;VA-API&quot; hstack
        /// </summary>
        public static Hstack_vaapiFilterGen Hstack_vaapiFilterGen(this ImageMap input) => new Hstack_vaapiFilterGen(input);
    }
}