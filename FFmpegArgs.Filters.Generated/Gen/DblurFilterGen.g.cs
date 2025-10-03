namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.C dblur             V-&gt;V       Apply Directional Blur filter.
    /// </summary>
    public class DblurFilterGen : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        internal DblurFilterGen(ImageMap input) : base("dblur", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set angle (from 0 to 360) (default 45)
        /// </summary>
        public DblurFilterGen angle(float angle) => this.SetOptionRange("angle", angle, 0, 360);
        /// <summary>
        ///  set radius (from 0 to 8192) (default 5)
        /// </summary>
        public DblurFilterGen radius(float radius) => this.SetOptionRange("radius", radius, 0, 8192);
        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 15)
        /// </summary>
        public DblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Directional Blur filter.
        /// </summary>
        public static DblurFilterGen DblurFilterGen(this ImageMap input0) => new DblurFilterGen(input0);
    }
}