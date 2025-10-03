﻿namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... ddagrab           |-&gt;V       Grab Windows Desktop images using Desktop Duplication API
    /// </summary>
    public class DdagrabFilterGen : SourceToImageFilter
    {
        internal DdagrabFilterGen(IImageFilterGraph input) : base("ddagrab", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  dda output index to capture (from 0 to INT_MAX) (default 0)
        /// </summary>
        public DdagrabFilterGen output_idx(int output_idx) => this.SetOptionRange("output_idx", output_idx, 0, INT_MAX);
        /// <summary>
        ///  draw the mouse pointer (default true)
        /// </summary>
        public DdagrabFilterGen draw_mouse(bool draw_mouse) => this.SetOption("draw_mouse", draw_mouse.ToFFmpegFlag());
        /// <summary>
        ///  set video frame rate (default &quot;30&quot;)
        /// </summary>
        public DdagrabFilterGen framerate(Rational framerate) => this.SetOption("framerate", framerate.ToString());
        /// <summary>
        ///  set video frame size
        /// </summary>
        public DdagrabFilterGen video_size(Size video_size) => this.SetOption("video_size", $"{video_size.Width}x{video_size.Height}");
        /// <summary>
        ///  capture area x offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public DdagrabFilterGen offset_x(int offset_x) => this.SetOptionRange("offset_x", offset_x, INT_MIN, INT_MAX);
        /// <summary>
        ///  capture area y offset (from INT_MIN to INT_MAX) (default 0)
        /// </summary>
        public DdagrabFilterGen offset_y(int offset_y) => this.SetOptionRange("offset_y", offset_y, INT_MIN, INT_MAX);
        /// <summary>
        ///  desired output format (from 0 to INT_MAX) (default 8bit)
        /// </summary>
        public DdagrabFilterGen output_fmt(DdagrabFilterGenOutput_fmt output_fmt) => this.SetOption("output_fmt", output_fmt.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  don&#39;t error on fallback to default 8 Bit format (default false)
        /// </summary>
        public DdagrabFilterGen allow_fallback(bool allow_fallback) => this.SetOption("allow_fallback", allow_fallback.ToFFmpegFlag());
        /// <summary>
        ///  exclude BGRA from format list (experimental, discouraged by Microsoft) (default false)
        /// </summary>
        public DdagrabFilterGen force_fmt(bool force_fmt) => this.SetOption("force_fmt", force_fmt.ToFFmpegFlag());
        /// <summary>
        ///  duplicate frames to maintain framerate (default true)
        /// </summary>
        public DdagrabFilterGen dup_frames(bool dup_frames) => this.SetOption("dup_frames", dup_frames.ToFFmpegFlag());
    }

    /// <summary>
    ///  desired output format (from 0 to INT_MAX) (default 8bit)
    /// </summary>
    public enum DdagrabFilterGenOutput_fmt
    {
        /// <summary>
        /// auto            0            ..FV....... let dda pick its preferred format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = 0,
        /// <summary>
        /// 8bit            87           ..FV....... only output default 8 Bit format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("8bit")]
        _8bit = 87,
        /// <summary>
        /// bgra            87           ..FV....... only output 8 Bit BGRA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bgra")]
        bgra = 87,
        /// <summary>
        /// 10bit           24           ..FV....... only output default 10 Bit format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("10bit")]
        _10bit = 24,
        /// <summary>
        /// x2bgr10         24           ..FV....... only output 10 Bit X2BGR10
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("x2bgr10")]
        x2bgr10 = 24,
        /// <summary>
        /// 16bit           10           ..FV....... only output default 16 Bit format
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("16bit")]
        _16bit = 10,
        /// <summary>
        /// rgbaf16         10           ..FV....... only output 16 Bit RGBAF16
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rgbaf16")]
        rgbaf16 = 10
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Grab Windows Desktop images using Desktop Duplication API
        /// </summary>
        public static DdagrabFilterGen DdagrabFilterGen(this IImageFilterGraph input) => new DdagrabFilterGen(input);
    }
}