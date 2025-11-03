namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. tremolo           A-&gt;A       Apply tremolo effect.
    /// </summary>
    public class TremoloFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal TremoloFilterGen(AudioMap input) : base("tremolo", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set frequency in hertz (from 0.1 to 20000) (default 5)
        /// </summary>
        public TremoloFilterGen f(double f) => this.SetOptionRange("f", f, 0.1, 20000);
        /// <summary>
        ///  set depth as percentage (from 0 to 1) (default 0.5)
        /// </summary>
        public TremoloFilterGen d(double d) => this.SetOptionRange("d", d, 0, 1);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply tremolo effect.
        /// </summary>
        public static TremoloFilterGen TremoloFilterGen(this AudioMap input0) => new TremoloFilterGen(input0);
    }
}