namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S epx               V-&gt;V       Scale the input using EPX algorithm.
    /// </summary>
    public class EpxFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal EpxFilterGen(ImageMap input) : base("epx", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set scale factor (from 2 to 3) (default 3)
        /// </summary>
        public EpxFilterGen n(int n) => this.SetOptionRange("n", n, 2, 3);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Scale the input using EPX algorithm.
        /// </summary>
        public static EpxFilterGen EpxFilterGen(this ImageMap input0) => new EpxFilterGen(input0);
    }
}