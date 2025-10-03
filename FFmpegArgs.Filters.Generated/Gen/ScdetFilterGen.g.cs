namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... scdet             V-&gt;V       Detect video scene change
    /// </summary>
    public class ScdetFilterGen : ImageToImageFilter
    {
        internal ScdetFilterGen(ImageMap input) : base("scdet", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set scene change detect threshold (from 0 to 100) (default 10)
        /// </summary>
        public ScdetFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold, 0, 100);
        /// <summary>
        ///  Set the flag to pass scene change frames (default false)
        /// </summary>
        public ScdetFilterGen sc_pass(bool sc_pass) => this.SetOption("sc_pass", sc_pass.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Detect video scene change
        /// </summary>
        public static ScdetFilterGen ScdetFilterGen(this ImageMap input0) => new ScdetFilterGen(input0);
    }
}