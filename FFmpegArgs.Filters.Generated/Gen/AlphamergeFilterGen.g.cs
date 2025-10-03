﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. alphamerge        VV-&gt;V      Copy the luma value of the second input into the alpha channel of the first input.
    /// </summary>
    public class AlphamergeFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal AlphamergeFilterGen(params ImageMap[] inputs) : base("alphamerge", inputs)
        {
            AddMapOut();
        }
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Copy the luma value of the second input into the alpha channel of the first input.
        /// </summary>
        public static AlphamergeFilterGen AlphamergeFilterGen(this ImageMap input0, ImageMap input1) => new AlphamergeFilterGen(input0, input1);
    }
}