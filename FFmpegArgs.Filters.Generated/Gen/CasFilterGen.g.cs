namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS cas               V-&gt;V       Contrast Adaptive Sharpen.
    /// </summary>
    public class CasFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal CasFilterGen(ImageMap input) : base("cas", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the sharpening strength (from 0 to 1) (default 0)
        /// </summary>
        public CasFilterGen strength(float strength) => this.SetOptionRange("strength", strength, 0, 1);
        /// <summary>
        ///  set what planes to filter (default 7)
        /// </summary>
        public CasFilterGen planes(String planes) => this.SetOption("planes", planes.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Contrast Adaptive Sharpen.
        /// </summary>
        public static CasFilterGen CasFilterGen(this ImageMap input0) => new CasFilterGen(input0);
    }
}