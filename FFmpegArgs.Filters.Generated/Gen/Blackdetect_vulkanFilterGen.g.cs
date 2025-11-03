namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. blackdetect_vulkan V-&gt;V       Detect video intervals that are (almost) black.
    /// </summary>
    public class Blackdetect_vulkanFilterGen : ImageToImageFilter
    {
        internal Blackdetect_vulkanFilterGen(ImageMap input) : base("blackdetect_vulkan", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
        /// </summary>
        public Blackdetect_vulkanFilterGen d(double d) => this.SetOptionRange("d", d, 0, DBL_MAX);
        /// <summary>
        ///  set minimum detected black duration in seconds (from 0 to DBL_MAX) (default 2)
        /// </summary>
        public Blackdetect_vulkanFilterGen black_min_duration(double black_min_duration) => this.SetOptionRange("black_min_duration", black_min_duration, 0, DBL_MAX);
        /// <summary>
        ///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
        /// </summary>
        public Blackdetect_vulkanFilterGen picture_black_ratio_th(double picture_black_ratio_th) => this.SetOptionRange("picture_black_ratio_th", picture_black_ratio_th, 0, 1);
        /// <summary>
        ///  set the picture black ratio threshold (from 0 to 1) (default 0.98)
        /// </summary>
        public Blackdetect_vulkanFilterGen pic_th(double pic_th) => this.SetOptionRange("pic_th", pic_th, 0, 1);
        /// <summary>
        ///  set the pixel black threshold (from 0 to 1) (default 0.1)
        /// </summary>
        public Blackdetect_vulkanFilterGen pixel_black_th(double pixel_black_th) => this.SetOptionRange("pixel_black_th", pixel_black_th, 0, 1);
        /// <summary>
        ///  set the pixel black threshold (from 0 to 1) (default 0.1)
        /// </summary>
        public Blackdetect_vulkanFilterGen pix_th(double pix_th) => this.SetOptionRange("pix_th", pix_th, 0, 1);
        /// <summary>
        ///  check alpha instead of luma (default false)
        /// </summary>
        public Blackdetect_vulkanFilterGen alpha(bool alpha) => this.SetOption("alpha", alpha.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Detect video intervals that are (almost) black.
        /// </summary>
        public static Blackdetect_vulkanFilterGen Blackdetect_vulkanFilterGen(this ImageMap input0) => new Blackdetect_vulkanFilterGen(input0);
    }
}