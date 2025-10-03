﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. vflip             V-&gt;V       Flip the input video vertically.
    /// </summary>
    public class VflipFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal VflipFilterGen(ImageMap input) : base("vflip", input)
        {
            AddMapOut();
        }
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Flip the input video vertically.
        /// </summary>
        public static VflipFilterGen VflipFilterGen(this ImageMap input0) => new VflipFilterGen(input0);
    }
}