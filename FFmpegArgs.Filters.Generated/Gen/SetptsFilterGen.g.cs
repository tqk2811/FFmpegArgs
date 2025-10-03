﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ..C setpts            V-&gt;V       Set PTS for the output video frame.
    /// </summary>
    public class SetptsFilterGen : ImageToImageFilter, ICommandSupport
    {
        internal SetptsFilterGen(ImageMap input) : base("setpts", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Expression determining the frame timestamp (default &quot;PTS&quot;)
        /// </summary>
        public SetptsFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Set PTS for the output video frame.
        /// </summary>
        public static SetptsFilterGen SetptsFilterGen(this ImageMap input0) => new SetptsFilterGen(input0);
    }
}