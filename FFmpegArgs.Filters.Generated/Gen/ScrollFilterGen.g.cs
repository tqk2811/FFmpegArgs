namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC scroll            V-&gt;V       Scroll input video.
    /// </summary>
    public class ScrollFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal ScrollFilterGen(ImageMap input) : base("scroll", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the horizontal scrolling speed (from -1 to 1) (default 0)
        /// </summary>
        public ScrollFilterGen horizontal(float horizontal) => this.SetOptionRange("horizontal", horizontal, -1, 1);
        /// <summary>
        ///  set the vertical scrolling speed (from -1 to 1) (default 0)
        /// </summary>
        public ScrollFilterGen vertical(float vertical) => this.SetOptionRange("vertical", vertical, -1, 1);
        /// <summary>
        ///  set initial horizontal position (from 0 to 1) (default 0)
        /// </summary>
        public ScrollFilterGen hpos(float hpos) => this.SetOptionRange("hpos", hpos, 0, 1);
        /// <summary>
        ///  set initial vertical position (from 0 to 1) (default 0)
        /// </summary>
        public ScrollFilterGen vpos(float vpos) => this.SetOptionRange("vpos", vpos, 0, 1);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Scroll input video.
        /// </summary>
        public static ScrollFilterGen ScrollFilterGen(this ImageMap input0) => new ScrollFilterGen(input0);
    }
}