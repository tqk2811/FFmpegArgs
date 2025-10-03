namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. sab               V-&gt;V       Apply shape adaptive blur.
    /// </summary>
    public class SabFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal SabFilterGen(ImageMap input) : base("sab", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set luma radius (from 0.1 to 4) (default 1)
        /// </summary>
        public SabFilterGen luma_radius(float luma_radius) => this.SetOptionRange("luma_radius", luma_radius, 0.1, 4);
        /// <summary>
        ///  set luma radius (from 0.1 to 4) (default 1)
        /// </summary>
        public SabFilterGen lr(float lr) => this.SetOptionRange("lr", lr, 0.1, 4);
        /// <summary>
        ///  set luma pre-filter radius (from 0.1 to 2) (default 1)
        /// </summary>
        public SabFilterGen luma_pre_filter_radius(float luma_pre_filter_radius) => this.SetOptionRange("luma_pre_filter_radius", luma_pre_filter_radius, 0.1, 2);
        /// <summary>
        ///  set luma pre-filter radius (from 0.1 to 2) (default 1)
        /// </summary>
        public SabFilterGen lpfr(float lpfr) => this.SetOptionRange("lpfr", lpfr, 0.1, 2);
        /// <summary>
        ///  set luma strength (from 0.1 to 100) (default 1)
        /// </summary>
        public SabFilterGen luma_strength(float luma_strength) => this.SetOptionRange("luma_strength", luma_strength, 0.1, 100);
        /// <summary>
        ///  set luma strength (from 0.1 to 100) (default 1)
        /// </summary>
        public SabFilterGen ls(float ls) => this.SetOptionRange("ls", ls, 0.1, 100);
        /// <summary>
        ///  set chroma radius (from -0.9 to 4) (default -0.9)
        /// </summary>
        public SabFilterGen chroma_radius(float chroma_radius) => this.SetOptionRange("chroma_radius", chroma_radius, -0.9, 4);
        /// <summary>
        ///  set chroma radius (from -0.9 to 4) (default -0.9)
        /// </summary>
        public SabFilterGen cr(float cr) => this.SetOptionRange("cr", cr, -0.9, 4);
        /// <summary>
        ///  set chroma pre-filter radius (from -0.9 to 2) (default -0.9)
        /// </summary>
        public SabFilterGen chroma_pre_filter_radius(float chroma_pre_filter_radius) => this.SetOptionRange("chroma_pre_filter_radius", chroma_pre_filter_radius, -0.9, 2);
        /// <summary>
        ///  set chroma pre-filter radius (from -0.9 to 2) (default -0.9)
        /// </summary>
        public SabFilterGen cpfr(float cpfr) => this.SetOptionRange("cpfr", cpfr, -0.9, 2);
        /// <summary>
        ///  set chroma strength (from -0.9 to 100) (default -0.9)
        /// </summary>
        public SabFilterGen chroma_strength(float chroma_strength) => this.SetOptionRange("chroma_strength", chroma_strength, -0.9, 100);
        /// <summary>
        ///  set chroma strength (from -0.9 to 100) (default -0.9)
        /// </summary>
        public SabFilterGen cs(float cs) => this.SetOptionRange("cs", cs, -0.9, 100);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply shape adaptive blur.
        /// </summary>
        public static SabFilterGen SabFilterGen(this ImageMap input0) => new SabFilterGen(input0);
    }
}