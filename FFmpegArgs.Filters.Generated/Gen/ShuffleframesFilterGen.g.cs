namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. shuffleframes     V-&gt;V       Shuffle video frames.
    /// </summary>
    public class ShuffleframesFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal ShuffleframesFilterGen(ImageMap input) : base("shuffleframes", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set destination indexes of input frames (default &quot;0&quot;)
        /// </summary>
        public ShuffleframesFilterGen mapping(String mapping) => this.SetOption("mapping", mapping.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Shuffle video frames.
        /// </summary>
        public static ShuffleframesFilterGen ShuffleframesFilterGen(this ImageMap input0) => new ShuffleframesFilterGen(input0);
    }
}