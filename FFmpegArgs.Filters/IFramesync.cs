using FFmpegArgs.Cores.Filters;

namespace FFmpegArgs.Filters
{
  public interface IFramesync : IFilter
  {
  }

  public static class FramesyncExtension
  {
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-filters.html#Options-for-filters-with-several-inputs-_0028framesync_0029 <br></br>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="filter"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    public static T EofAction<T>(this T filter, EofAction action) where T : BaseOption, IFramesync
      => filter.SetOption("eof_action", action.ToString().ToLower());

    public static T Shortest<T>(this T filter, bool flag) where T : BaseOption, IFramesync
      => filter.SetOption("shortest", flag.ToFFmpegFlag());

    public static T Repeatlast<T>(this T filter, bool flag) where T : BaseOption, IFramesync
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
