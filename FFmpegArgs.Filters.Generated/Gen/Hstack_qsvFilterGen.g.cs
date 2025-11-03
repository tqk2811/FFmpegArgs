namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. hstack_qsv        N-&gt;V       &quot;Quick Sync Video&quot; hstack
    /// </summary>
    public class Hstack_qsvFilterGen : ImageToImageFilter
    {
        internal Hstack_qsvFilterGen(params ImageMap[] inputs) : base("hstack_qsv", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set number of inputs (from 2 to 65535) (default 2)
        /// </summary>
        public Hstack_qsvFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs, 2, 65535);
        /// <summary>
        ///  Force termination when the shortest input terminates (default false)
        /// </summary>
        public Hstack_qsvFilterGen shortest(bool shortest) => this.SetOption("shortest", shortest.ToFFmpegFlag());
        /// <summary>
        ///  Set output height (0 to use the height of input 0) (from 0 to 65535) (default 0)
        /// </summary>
        public Hstack_qsvFilterGen height(int height) => this.SetOptionRange("height", height, 0, 65535);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// &quot;Quick Sync Video&quot; hstack
        /// </summary>
        public static Hstack_qsvFilterGen Hstack_qsvFilterGen(this ImageMap input) => new Hstack_qsvFilterGen(input);
    }
}