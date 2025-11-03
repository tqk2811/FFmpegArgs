namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. hflip_vulkan      V-&gt;V       Horizontally flip the input video in Vulkan
    /// </summary>
    public class Hflip_vulkanFilterGen : ImageToImageFilter
    {
        internal Hflip_vulkanFilterGen(ImageMap input) : base("hflip_vulkan", input)
        {
            AddMapOut();
        }
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Horizontally flip the input video in Vulkan
        /// </summary>
        public static Hflip_vulkanFilterGen Hflip_vulkanFilterGen(this ImageMap input0) => new Hflip_vulkanFilterGen(input0);
    }
}