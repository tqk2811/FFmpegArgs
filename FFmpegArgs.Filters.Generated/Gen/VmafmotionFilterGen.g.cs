namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... vmafmotion        V-&gt;V       Calculate the VMAF Motion score.
    /// </summary>
    public class VmafmotionFilterGen : ImageToImageFilter
    {
        internal VmafmotionFilterGen(ImageMap input) : base("vmafmotion", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Set file where to store per-frame difference information
        /// </summary>
        public VmafmotionFilterGen stats_file(String stats_file) => this.SetOption("stats_file", stats_file.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate the VMAF Motion score.
        /// </summary>
        public static VmafmotionFilterGen VmafmotionFilterGen(this ImageMap input0) => new VmafmotionFilterGen(input0);
    }
}