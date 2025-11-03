namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. scdet_vulkan      V-&gt;V       Detect video scene change
    /// </summary>
    public class Scdet_vulkanFilterGen : ImageToImageFilter
    {
        internal Scdet_vulkanFilterGen(ImageMap input) : base("scdet_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set scene change detect threshold (from 0 to 100) (default 10)
        /// </summary>
        public Scdet_vulkanFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold, 0, 100);
        /// <summary>
        ///  Set the flag to pass scene change frames (default false)
        /// </summary>
        public Scdet_vulkanFilterGen sc_pass(bool sc_pass) => this.SetOption("sc_pass", sc_pass.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Detect video scene change
        /// </summary>
        public static Scdet_vulkanFilterGen Scdet_vulkanFilterGen(this ImageMap input0) => new Scdet_vulkanFilterGen(input0);
    }
}