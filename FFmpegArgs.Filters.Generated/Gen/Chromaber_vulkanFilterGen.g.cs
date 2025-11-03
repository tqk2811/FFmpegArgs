namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. chromaber_vulkan  V-&gt;V       Offset chroma of input video (chromatic aberration)
    /// </summary>
    public class Chromaber_vulkanFilterGen : ImageToImageFilter
    {
        internal Chromaber_vulkanFilterGen(ImageMap input) : base("chromaber_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set horizontal distortion amount (from -10 to 10) (default 0)
        /// </summary>
        public Chromaber_vulkanFilterGen dist_x(float dist_x) => this.SetOptionRange("dist_x", dist_x, -10, 10);
        /// <summary>
        ///  Set vertical distortion amount (from -10 to 10) (default 0)
        /// </summary>
        public Chromaber_vulkanFilterGen dist_y(float dist_y) => this.SetOptionRange("dist_y", dist_y, -10, 10);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Offset chroma of input video (chromatic aberration)
        /// </summary>
        public static Chromaber_vulkanFilterGen Chromaber_vulkanFilterGen(this ImageMap input0) => new Chromaber_vulkanFilterGen(input0);
    }
}