namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... siti              V-&gt;V       Calculate spatial information (SI) and temporal information (TI).
    /// </summary>
    public class SitiFilterGen : ImageToImageFilter
    {
        internal SitiFilterGen(ImageMap input) : base("siti", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Print summary showing average values (default false)
        /// </summary>
        public SitiFilterGen print_summary(bool print_summary) => this.SetOption("print_summary", print_summary.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate spatial information (SI) and temporal information (TI).
        /// </summary>
        public static SitiFilterGen SitiFilterGen(this ImageMap input0) => new SitiFilterGen(input0);
    }
}