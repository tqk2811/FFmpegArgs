using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISliceThreading
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public static class SliceThreadingExtension
    {
        //Example https://github.com/tanersener/ffmpeg-video-slideshow-scripts/blob/0aad954923d669255f4b2b50adc87f37ff4135ba/transition_scripts/push_vertical.sh#L112
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="threads"></param>
        /// <returns></returns>
        public static T Threads<T>(this T t, int threads) where T : BaseOption, IFilter<IMap, IMap>, ISliceThreading
            => t.SetOptionRange("threads", threads, -1, int.MaxValue);
    }
}
