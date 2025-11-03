namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS aphaseshift       A-&gt;A       Apply phase shifting to input audio.
    /// </summary>
    public class AphaseshiftFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AphaseshiftFilterGen(AudioMap input) : base("aphaseshift", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set phase shift (from -1 to 1) (default 0)
        /// </summary>
        public AphaseshiftFilterGen shift(double shift) => this.SetOptionRange("shift", shift, -1, 1);
        /// <summary>
        ///  set output level (from 0 to 1) (default 1)
        /// </summary>
        public AphaseshiftFilterGen level(double level) => this.SetOptionRange("level", level, 0, 1);
        /// <summary>
        ///  set filter order (from 1 to 16) (default 8)
        /// </summary>
        public AphaseshiftFilterGen order(int order) => this.SetOptionRange("order", order, 1, 16);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply phase shifting to input audio.
        /// </summary>
        public static AphaseshiftFilterGen AphaseshiftFilterGen(this AudioMap input0) => new AphaseshiftFilterGen(input0);
    }
}