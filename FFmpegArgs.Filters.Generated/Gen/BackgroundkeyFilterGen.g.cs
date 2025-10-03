namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC backgroundkey     V-&gt;V       Turns a static background into transparency.
    /// </summary>
    public class BackgroundkeyFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal BackgroundkeyFilterGen(ImageMap input) : base("backgroundkey", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the scene change threshold (from 0 to 1) (default 0.08)
        /// </summary>
        public BackgroundkeyFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold, 0, 1);
        /// <summary>
        ///  set the similarity (from 0 to 1) (default 0.1)
        /// </summary>
        public BackgroundkeyFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity, 0, 1);
        /// <summary>
        ///  set the blend value (from 0 to 1) (default 0)
        /// </summary>
        public BackgroundkeyFilterGen blend(float blend) => this.SetOptionRange("blend", blend, 0, 1);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Turns a static background into transparency.
        /// </summary>
        public static BackgroundkeyFilterGen BackgroundkeyFilterGen(this ImageMap input0) => new BackgroundkeyFilterGen(input0);
    }
}