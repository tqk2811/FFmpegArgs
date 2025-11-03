namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS greyedge          V-&gt;V       Estimates scene illumination by grey edge assumption.
    /// </summary>
    public class GreyedgeFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal GreyedgeFilterGen(ImageMap input) : base("greyedge", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set differentiation order (from 0 to 2) (default 1)
        /// </summary>
        public GreyedgeFilterGen difford(int difford) => this.SetOptionRange("difford", difford, 0, 2);
        /// <summary>
        ///  set Minkowski norm (from 0 to 20) (default 1)
        /// </summary>
        public GreyedgeFilterGen minknorm(int minknorm) => this.SetOptionRange("minknorm", minknorm, 0, 20);
        /// <summary>
        ///  set sigma (from 0 to 1024) (default 1)
        /// </summary>
        public GreyedgeFilterGen sigma(double sigma) => this.SetOptionRange("sigma", sigma, 0, 1024);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Estimates scene illumination by grey edge assumption.
        /// </summary>
        public static GreyedgeFilterGen GreyedgeFilterGen(this ImageMap input0) => new GreyedgeFilterGen(input0);
    }
}