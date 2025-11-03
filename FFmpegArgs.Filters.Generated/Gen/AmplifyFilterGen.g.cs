namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS amplify           V-&gt;V       Amplify changes between successive video frames.
    /// </summary>
    public class AmplifyFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal AmplifyFilterGen(ImageMap input) : base("amplify", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set radius (from 1 to 63) (default 2)
        /// </summary>
        public AmplifyFilterGen radius(int radius) => this.SetOptionRange("radius", radius, 1, 63);
        /// <summary>
        ///  set factor (from 0 to 65535) (default 2)
        /// </summary>
        public AmplifyFilterGen factor(float factor) => this.SetOptionRange("factor", factor, 0, 65535);
        /// <summary>
        ///  set threshold (from 0 to 65535) (default 10)
        /// </summary>
        public AmplifyFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold, 0, 65535);
        /// <summary>
        ///  set tolerance (from 0 to 65535) (default 0)
        /// </summary>
        public AmplifyFilterGen tolerance(float tolerance) => this.SetOptionRange("tolerance", tolerance, 0, 65535);
        /// <summary>
        ///  set low limit for amplification (from 0 to 65535) (default 65535)
        /// </summary>
        public AmplifyFilterGen low(float low) => this.SetOptionRange("low", low, 0, 65535);
        /// <summary>
        ///  set high limit for amplification (from 0 to 65535) (default 65535)
        /// </summary>
        public AmplifyFilterGen high(float high) => this.SetOptionRange("high", high, 0, 65535);
        /// <summary>
        ///  set what planes to filter (default 7)
        /// </summary>
        public AmplifyFilterGen planes(String planes) => this.SetOption("planes", planes.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Amplify changes between successive video frames.
        /// </summary>
        public static AmplifyFilterGen AmplifyFilterGen(this ImageMap input0) => new AmplifyFilterGen(input0);
    }
}