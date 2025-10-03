﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. uspp              V-&gt;V       Apply Ultra Simple / Slow Post-processing filter.
    /// </summary>
    public class UsppFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal UsppFilterGen(ImageMap input) : base("uspp", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set quality (from 0 to 8) (default 3)
        /// </summary>
        public UsppFilterGen quality(int quality) => this.SetOptionRange("quality", quality, 0, 8);
        /// <summary>
        ///  force a constant quantizer parameter (from 0 to 63) (default 0)
        /// </summary>
        public UsppFilterGen qp(int qp) => this.SetOptionRange("qp", qp, 0, 63);
        /// <summary>
        ///  use B-frames&#39; QP (default false)
        /// </summary>
        public UsppFilterGen use_bframe_qp(bool use_bframe_qp) => this.SetOption("use_bframe_qp", use_bframe_qp.ToFFmpegFlag());
        /// <summary>
        ///  Codec name (default &quot;snow&quot;)
        /// </summary>
        public UsppFilterGen codec(String codec) => this.SetOption("codec", codec.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Ultra Simple / Slow Post-processing filter.
        /// </summary>
        public static UsppFilterGen UsppFilterGen(this ImageMap input0) => new UsppFilterGen(input0);
    }
}