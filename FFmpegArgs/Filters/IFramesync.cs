using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
    public interface IFramesync
    {
    }

    public static class FramesyncExtension
    {
        /// <summary>
        /// https://ffmpeg.org/ffmpeg-filters.html#Options-for-filters-with-several-inputs-_0028framesync_0029 <br></br>
        /// The action to take when EOF is encountered on the secondary input
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T EofAction<T>(this T filter, EofAction action)
            where T : BaseOption, IFilter<IMap, IMap>, IFramesync
          => filter.SetOption("eof_action", action.ToString().ToLower());

        /// <summary>
        /// If set to 1, force the output to terminate when the shortest input terminates. Default value is 0.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T Shortest<T>(this T filter, bool flag)
             where T : BaseOption, IFilter<IMap, IMap>, IFramesync
          => filter.SetOption("shortest", flag.ToFFmpegFlag());

        /// <summary>
        /// If set to 1, force the filter to extend the last frame of secondary streams until the end of the primary stream. A value of 0 disables this behavior. Default value is 1.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T Repeatlast<T>(this T filter, bool flag)
             where T : BaseOption, IFilter<IMap, IMap>, IFramesync
          => filter.SetOption("repeatlast", flag.ToFFmpegFlag());
    }

    /// <summary> 
    /// https://ffmpeg.org/ffmpeg-filters.html#framesync <br></br>
    /// The action to take when EOF is encountered on the secondary input; it accepts one of the following values:
    /// </summary>
    public enum EofAction
    {
        /// <summary>
        /// Repeat the last frame (the default).
        /// </summary>
        Repeat,

        /// <summary>
        /// End both streams.
        /// </summary>
        EndAll,

        /// <summary>
        /// Pass the main input through.
        /// </summary>
        Pass
    }
}
