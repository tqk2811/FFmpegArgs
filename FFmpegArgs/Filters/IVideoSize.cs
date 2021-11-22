using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Filters.Enums;
using System.Drawing;

namespace FFmpegArgs.Filters
{
    public interface IVideoSize : IFilter
    {
    }

    public static class VideoSizeExtensions
    {
        /// <summary>
        /// Set the video size
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public static T Size<T>(this T t, VideoSizeUtils videoSize) where T : BaseFilterOption, IVideoSize
          => t.SetOption("s", videoSize.GetAttribute<NameAttribute>().Name);

        /// <summary>
        /// Set the video size
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public static T Size<T>(this T t, Size videoSize) where T : BaseFilterOption, IVideoSize
          => t.SetOption("s", $"{videoSize.Width}x{videoSize.Height}");
    }
}
