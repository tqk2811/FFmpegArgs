﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... bench             V-&gt;V       Benchmark part of a filtergraph.
    /// </summary>
    public class BenchFilterGen : ImageToImageFilter
    {
        internal BenchFilterGen(ImageMap input) : base("bench", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set action (from 0 to 1) (default start)
        /// </summary>
        public BenchFilterGen action(BenchFilterGenAction action) => this.SetOption("action", action.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set action (from 0 to 1) (default start)
    /// </summary>
    public enum BenchFilterGenAction
    {
        /// <summary>
        /// start           0            ..FV....... start timer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("start")]
        start = 0,
        /// <summary>
        /// stop            1            ..FV....... stop timer
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stop")]
        stop = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Benchmark part of a filtergraph.
        /// </summary>
        public static BenchFilterGen BenchFilterGen(this ImageMap input0) => new BenchFilterGen(input0);
    }
}