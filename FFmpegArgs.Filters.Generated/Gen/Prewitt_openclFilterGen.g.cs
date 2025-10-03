﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... prewitt_opencl    V-&gt;V       Apply prewitt operator
    /// </summary>
    public class Prewitt_openclFilterGen : ImageToImageFilter
    {
        internal Prewitt_openclFilterGen(ImageMap input) : base("prewitt_opencl", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 15)
        /// </summary>
        public Prewitt_openclFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  set scale (from 0 to 65535) (default 1)
        /// </summary>
        public Prewitt_openclFilterGen scale(float scale) => this.SetOptionRange("scale", scale, 0, 65535);
        /// <summary>
        ///  set delta (from -65535 to 65535) (default 0)
        /// </summary>
        public Prewitt_openclFilterGen delta(float delta) => this.SetOptionRange("delta", delta, -65535, 65535);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply prewitt operator
        /// </summary>
        public static Prewitt_openclFilterGen Prewitt_openclFilterGen(this ImageMap input0) => new Prewitt_openclFilterGen(input0);
    }
}