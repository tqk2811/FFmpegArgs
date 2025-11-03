namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS dctdnoiz          V-&gt;V       Denoise frames using 2D DCT.
    /// </summary>
    public class DctdnoizFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal DctdnoizFilterGen(ImageMap input) : base("dctdnoiz", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set noise sigma constant (from 0 to 999) (default 0)
        /// </summary>
        public DctdnoizFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma, 0, 999);
        /// <summary>
        ///  set number of block overlapping pixels (from -1 to 15) (default -1)
        /// </summary>
        public DctdnoizFilterGen overlap(int overlap) => this.SetOptionRange("overlap", overlap, -1, 15);
        /// <summary>
        ///  set coefficient factor expression
        /// </summary>
        public DctdnoizFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
        /// <summary>
        ///  set the block size, expressed in bits (from 3 to 4) (default 3)
        /// </summary>
        public DctdnoizFilterGen n(int n) => this.SetOptionRange("n", n, 3, 4);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Denoise frames using 2D DCT.
        /// </summary>
        public static DctdnoizFilterGen DctdnoizFilterGen(this ImageMap input0) => new DctdnoizFilterGen(input0);
    }
}