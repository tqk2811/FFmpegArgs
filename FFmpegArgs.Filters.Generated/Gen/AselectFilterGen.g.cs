﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... aselect           A-&gt;N       Select audio frames to pass in output.
    /// </summary>
    public class AselectFilterGen : AudioToAudioFilter
    {
        internal AselectFilterGen(AudioMap input, int outputCount) : base("aselect", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  set an expression to use for selecting frames (default &quot;1&quot;)
        /// </summary>
        public AselectFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
        /// <summary>
        ///  set the number of outputs (from 1 to INT_MAX) (default 1)
        /// </summary>
        public AselectFilterGen outputs(int outputs) => this.SetOptionRange("outputs", outputs, 1, INT_MAX);
        /// <summary>
        ///  set the number of outputs (from 1 to INT_MAX) (default 1)
        /// </summary>
        public AselectFilterGen n(int n) => this.SetOptionRange("n", n, 1, INT_MAX);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Select audio frames to pass in output.
        /// </summary>
        public static AselectFilterGen AselectFilterGen(this AudioMap input0, int outputCount) => new AselectFilterGen(input0, outputCount);
    }
}