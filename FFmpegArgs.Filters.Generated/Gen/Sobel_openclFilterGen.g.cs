﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... sobel_opencl      V-&gt;V       Apply sobel operator
    /// </summary>
    public class Sobel_openclFilterGen : ImageToImageFilter
    {
        internal Sobel_openclFilterGen(ImageMap input) : base("sobel_opencl", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 15)
        /// </summary>
        public Sobel_openclFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  set scale (from 0 to 65535) (default 1)
        /// </summary>
        public Sobel_openclFilterGen scale(float scale) => this.SetOptionRange("scale", scale, 0, 65535);
        /// <summary>
        ///  set delta (from -65535 to 65535) (default 0)
        /// </summary>
        public Sobel_openclFilterGen delta(float delta) => this.SetOptionRange("delta", delta, -65535, 65535);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply sobel operator
        /// </summary>
        public static Sobel_openclFilterGen Sobel_openclFilterGen(this ImageMap input0) => new Sobel_openclFilterGen(input0);
    }
}