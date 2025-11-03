namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. fspp              V-&gt;V       Apply Fast Simple Post-processing filter.
    /// </summary>
    public class FsppFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal FsppFilterGen(ImageMap input) : base("fspp", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set quality (from 4 to 5) (default 4)
        /// </summary>
        public FsppFilterGen quality(int quality) => this.SetOptionRange("quality", quality, 4, 5);
        /// <summary>
        ///  force a constant quantizer parameter (from 0 to 64) (default 0)
        /// </summary>
        public FsppFilterGen qp(int qp) => this.SetOptionRange("qp", qp, 0, 64);
        /// <summary>
        ///  set filter strength (from -15 to 32) (default 0)
        /// </summary>
        public FsppFilterGen strength(int strength) => this.SetOptionRange("strength", strength, -15, 32);
        /// <summary>
        ///  use B-frames&#39; QP (default false)
        /// </summary>
        public FsppFilterGen use_bframe_qp(bool use_bframe_qp) => this.SetOption("use_bframe_qp", use_bframe_qp.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Fast Simple Post-processing filter.
        /// </summary>
        public static FsppFilterGen FsppFilterGen(this ImageMap input0) => new FsppFilterGen(input0);
    }
}