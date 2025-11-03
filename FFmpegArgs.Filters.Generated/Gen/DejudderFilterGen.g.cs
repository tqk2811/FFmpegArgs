namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. dejudder          V-&gt;V       Remove judder produced by pullup.
    /// </summary>
    public class DejudderFilterGen : ImageToImageFilter
    {
        internal DejudderFilterGen(ImageMap input) : base("dejudder", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the length of the cycle to use for dejuddering (from 2 to 240) (default 4)
        /// </summary>
        public DejudderFilterGen cycle(int cycle) => this.SetOptionRange("cycle", cycle, 2, 240);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Remove judder produced by pullup.
        /// </summary>
        public static DejudderFilterGen DejudderFilterGen(this ImageMap input0) => new DejudderFilterGen(input0);
    }
}