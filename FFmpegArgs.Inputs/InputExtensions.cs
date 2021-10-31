using FFmpegArgs.Cores.Inputs;
using FFmpegArgs.Exceptions;

namespace FFmpegArgs.Inputs
{
  /// <summary>
  /// https://ffmpeg.org/ffmpeg.html#Main-options
  /// </summary>
  public static class InputExtensions
  {
    public static T Fmt<T>(this T baseInput, string fmt) where T : BaseInput
      => baseInput.SetOption("-f", fmt);

    public static T StreamLoop<T>(this T baseInput, int number) where T : BaseInput
    {
      if (number <= 0) throw new InvalidRangeException($"{nameof(number)} <= 0");
      return baseInput.SetOption("-stream_loop", number.ToString());
    }

    public static T Loop<T>(this T baseInput, int number) where T : BaseInput
    {
      if (number <= 0) throw new InvalidRangeException($"{nameof(number)} <= 0");
      return baseInput.SetOption("-loop", number.ToString());
    }

    public static T FrameRate<T>(this T baseInput, int r) where T : BaseInput
      => baseInput.SetOption("-r", r);
  }
}
