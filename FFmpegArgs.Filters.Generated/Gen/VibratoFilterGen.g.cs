﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. vibrato           A-&gt;A       Apply vibrato effect.
    /// </summary>
    public class VibratoFilterGen : AudioToAudioFilter, ITimelineSupport
    {
        internal VibratoFilterGen(AudioMap input) : base("vibrato", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set frequency in hertz (from 0.1 to 20000) (default 5)
        /// </summary>
        public VibratoFilterGen f(double f) => this.SetOptionRange("f", f, 0.1, 20000);
        /// <summary>
        ///  set depth as percentage (from 0 to 1) (default 0.5)
        /// </summary>
        public VibratoFilterGen d(double d) => this.SetOptionRange("d", d, 0, 1);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply vibrato effect.
        /// </summary>
        public static VibratoFilterGen VibratoFilterGen(this AudioMap input0) => new VibratoFilterGen(input0);
    }
}