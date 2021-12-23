using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC deband            V->V       Debands video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#deband
    /// </summary>
    public class DebandFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        readonly FFmpegExpression expression = new FFmpegExpression();
        internal DebandFilter(ImageMap imageMap) : base("deband", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set banding detection threshold for each plane. Default is 0.02. Valid range is 0.00003 to 0.5. If difference between current pixel and reference pixel is less than threshold, it will be considered as banded.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public DebandFilter BandingDetectionThreshold(DebandPlane plane, float val)
            => this.SetOptionRange(plane.ToString().Substring(1), val, 0.00003, 0.5);

        /// <summary>
        /// Banding detection range in pixels. Default is 16. If positive, random number in range 0 to set value will be used. If negative, exact absolute value will be used. The range defines square of four pixels around current pixel.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public DebandFilter Range(int range)
            => this.SetOptionRange("range", range, int.MinValue, int.MaxValue);

        /// <summary>
        /// Set direction in radians from which four pixel will be compared. If positive, random direction from 0 to set direction will be picked. If negative, exact of absolute value will be picked. For example direction 0, -PI or -2*PI radians will pick only pixels on same row and -PI/2 will pick only pixels on same column.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public DebandFilter Direction(float d)
            => this.SetOptionRange("d", d, -6.28319, 6.28319);

        /// <summary>
        /// If enabled, current pixel is compared with average value of all four surrounding pixels. The default is enabled. If disabled current pixel is compared with all four surrounding pixels. The pixel is considered banded if only all four differences with surrounding pixels are less than threshold.
        /// </summary>
        /// <returns></returns>
        public DebandFilter Blur(bool flag)
            => this.SetOption("b", flag.ToFFmpegFlag());

        /// <summary>
        /// If enabled, current pixel is changed if and only if all pixel components are banded, e.g. banding detection threshold is triggered for all color components. The default is disabled.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public DebandFilter Coupling(bool flag)
            => this.SetOption("c", flag.ToFFmpegFlag());

    }

    public static class DebandFilterExtensions
    {
        /// <summary>
        /// Remove banding artifacts from input video. It works by replacing banded pixels with average value of referenced pixels.
        /// </summary>
        public static DebandFilter DebandFilter(this ImageMap imageMap)
          => new DebandFilter(imageMap);
    }

    public enum DebandPlane
    {
        _1thr,
        _2thr,
        _3thr,
        _4thr,
    }
}
