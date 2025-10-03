﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... deflicker         V-&gt;V       Remove temporal frame luminance variations.
    /// </summary>
    public class DeflickerFilterGen : ImageToImageFilter
    {
        internal DeflickerFilterGen(ImageMap input) : base("deflicker", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set how many frames to use (from 2 to 129) (default 5)
        /// </summary>
        public DeflickerFilterGen size(int size) => this.SetOptionRange("size", size, 2, 129);
        /// <summary>
        ///  set how to smooth luminance (from 0 to 6) (default am)
        /// </summary>
        public DeflickerFilterGen mode(DeflickerFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  leave frames unchanged (default false)
        /// </summary>
        public DeflickerFilterGen bypass(bool bypass) => this.SetOption("bypass", bypass.ToFFmpegFlag());
    }

    /// <summary>
    ///  set how to smooth luminance (from 0 to 6) (default am)
    /// </summary>
    public enum DeflickerFilterGenMode
    {
        /// <summary>
        /// am              0            ..FV....... arithmetic mean
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("am")]
        am = 0,
        /// <summary>
        /// gm              1            ..FV....... geometric mean
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gm")]
        gm = 1,
        /// <summary>
        /// hm              2            ..FV....... harmonic mean
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hm")]
        hm = 2,
        /// <summary>
        /// qm              3            ..FV....... quadratic mean
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qm")]
        qm = 3,
        /// <summary>
        /// cm              4            ..FV....... cubic mean
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cm")]
        cm = 4,
        /// <summary>
        /// pm              5            ..FV....... power mean
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pm")]
        pm = 5,
        /// <summary>
        /// median          6            ..FV....... median
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("median")]
        median = 6
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Remove temporal frame luminance variations.
        /// </summary>
        public static DeflickerFilterGen DeflickerFilterGen(this ImageMap input0) => new DeflickerFilterGen(input0);
    }
}