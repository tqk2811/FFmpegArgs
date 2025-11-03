namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S hqx               V-&gt;V       Scale the input by 2, 3 or 4 using the hq*x magnification algorithm.
    /// </summary>
    public class HqxFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal HqxFilterGen(ImageMap input) : base("hqx", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set scale factor (from 2 to 4) (default 3)
        /// </summary>
        public HqxFilterGen n(int n) => this.SetOptionRange("n", n, 2, 4);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Scale the input by 2, 3 or 4 using the hq*x magnification algorithm.
        /// </summary>
        public static HqxFilterGen HqxFilterGen(this ImageMap input0) => new HqxFilterGen(input0);
    }
}