namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. vstack_vaapi      N-&gt;V       &quot;VA-API&quot; vstack
    /// </summary>
    public class Vstack_vaapiFilterGen : ImageToImageFilter
    {
        internal Vstack_vaapiFilterGen(params ImageMap[] inputs) : base("vstack_vaapi", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set number of inputs (from 2 to 65535) (default 2)
        /// </summary>
        public Vstack_vaapiFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 2, 65535);
        /// <summary>
        ///  Force termination when the shortest input terminates (default false)
        /// </summary>
        public Vstack_vaapiFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  Set output width (0 to use the width of input 0) (from 0 to 65535) (default 0)
        /// </summary>
        public Vstack_vaapiFilterGen width(int width) => this.SetOptionRange("width", width, 0, 65535);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// &quot;VA-API&quot; vstack
        /// </summary>
        public static Vstack_vaapiFilterGen Vstack_vaapiFilterGen(this ImageMap input) => new Vstack_vaapiFilterGen(input);
    }
}