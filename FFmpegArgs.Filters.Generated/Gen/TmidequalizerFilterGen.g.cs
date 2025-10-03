namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. tmidequalizer     V-&gt;V       Apply Temporal Midway Equalization.
    /// </summary>
    public class TmidequalizerFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal TmidequalizerFilterGen(ImageMap input) : base("tmidequalizer", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set radius (from 1 to 127) (default 5)
        /// </summary>
        public TmidequalizerFilterGen radius(int radius) => this.SetOptionRange("radius", radius, 1, 127);
        /// <summary>
        ///  set sigma (from 0 to 1) (default 0.5)
        /// </summary>
        public TmidequalizerFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma, 0, 1);
        /// <summary>
        ///  set planes (from 0 to 15) (default 15)
        /// </summary>
        public TmidequalizerFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Temporal Midway Equalization.
        /// </summary>
        public static TmidequalizerFilterGen TmidequalizerFilterGen(this ImageMap input0) => new TmidequalizerFilterGen(input0);
    }
}