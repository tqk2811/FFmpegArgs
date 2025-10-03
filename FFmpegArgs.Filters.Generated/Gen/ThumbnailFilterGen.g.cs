﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. thumbnail         V-&gt;V       Select the most representative frame in a given sequence of consecutive frames.
    /// </summary>
    public class ThumbnailFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ThumbnailFilterGen(ImageMap input) : base("thumbnail", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the frames batch size (from 2 to INT_MAX) (default 100)
        /// </summary>
        public ThumbnailFilterGen n(int n) => this.SetOptionRange("n", n, 2, INT_MAX);
        /// <summary>
        ///  force stats logging level (from INT_MIN to INT_MAX) (default info)
        /// </summary>
        public ThumbnailFilterGen log(ThumbnailFilterGenLog log) => this.SetOption("log", log.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  force stats logging level (from INT_MIN to INT_MAX) (default info)
    /// </summary>
    public enum ThumbnailFilterGenLog
    {
        /// <summary>
        /// quiet           -8           ..FV....... logging disabled
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quiet")]
        quiet = -8,
        /// <summary>
        /// info            32           ..FV....... information logging level
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("info")]
        info = 32,
        /// <summary>
        /// verbose         40           ..FV....... verbose logging level
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("verbose")]
        verbose = 40
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Select the most representative frame in a given sequence of consecutive frames.
        /// </summary>
        public static ThumbnailFilterGen ThumbnailFilterGen(this ImageMap input0) => new ThumbnailFilterGen(input0);
    }
}