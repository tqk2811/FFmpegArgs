namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. avgblur_vulkan    V-&gt;V       Apply avgblur mask to input video
    /// </summary>
    public class Avgblur_vulkanFilterGen : ImageToImageFilter
    {
        internal Avgblur_vulkanFilterGen(ImageMap input) : base("avgblur_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set horizontal radius (from 1 to 32) (default 3)
        /// </summary>
        public Avgblur_vulkanFilterGen sizeX(int sizeX) => this.SetOptionRange("sizeX", sizeX, 1, 32);
        /// <summary>
        ///  Set vertical radius (from 1 to 32) (default 3)
        /// </summary>
        public Avgblur_vulkanFilterGen sizeY(int sizeY) => this.SetOptionRange("sizeY", sizeY, 1, 32);
        /// <summary>
        ///  Set planes to filter (bitmask) (from 0 to 15) (default 15)
        /// </summary>
        public Avgblur_vulkanFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply avgblur mask to input video
        /// </summary>
        public static Avgblur_vulkanFilterGen Avgblur_vulkanFilterGen(this ImageMap input0) => new Avgblur_vulkanFilterGen(input0);
    }
}