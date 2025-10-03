﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. adeclip           A-&gt;A       Remove clipping from input audio.
    /// </summary>
    public class AdeclipFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AdeclipFilterGen(AudioMap input) : base("adeclip", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set window size (from 10 to 100) (default 55)
        /// </summary>
        public AdeclipFilterGen window(double window) => this.SetOptionRange("window", window, 10, 100);
        /// <summary>
        ///  set window overlap (from 50 to 95) (default 75)
        /// </summary>
        public AdeclipFilterGen overlap(double overlap) => this.SetOptionRange("overlap", overlap, 50, 95);
        /// <summary>
        ///  set autoregression order (from 0 to 25) (default 8)
        /// </summary>
        public AdeclipFilterGen arorder(double arorder) => this.SetOptionRange("arorder", arorder, 0, 25);
        /// <summary>
        ///  set threshold (from 1 to 100) (default 10)
        /// </summary>
        public AdeclipFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold, 1, 100);
        /// <summary>
        ///  set histogram size (from 100 to 9999) (default 1000)
        /// </summary>
        public AdeclipFilterGen hsize(int hsize) => this.SetOptionRange("hsize", hsize, 100, 9999);
        /// <summary>
        ///  set histogram size (from 100 to 9999) (default 1000)
        /// </summary>
        public AdeclipFilterGen n(int n) => this.SetOptionRange("n", n, 100, 9999);
        /// <summary>
        ///  set overlap method (from 0 to 1) (default add)
        /// </summary>
        public AdeclipFilterGen method(AdeclipFilterGenMethod method) => this.SetOption("method", method.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set overlap method (from 0 to 1) (default add)
    /// </summary>
    public enum AdeclipFilterGenMethod
    {
        /// <summary>
        /// add             0            ..F.A...... overlap-add
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("add")]
        add = 0,
        /// <summary>
        /// a               0            ..F.A...... overlap-add
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("a")]
        a = 0,
        /// <summary>
        /// save            1            ..F.A...... overlap-save
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("save")]
        save = 1,
        /// <summary>
        /// s               1            ..F.A...... overlap-save
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Remove clipping from input audio.
        /// </summary>
        public static AdeclipFilterGen AdeclipFilterGen(this AudioMap input0) => new AdeclipFilterGen(input0);
    }
}