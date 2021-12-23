using FFmpegArgs.Cores.Inputs;
using FFmpegArgs.Exceptions;

namespace FFmpegArgs.Inputs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg.html#Main-options
    /// </summary>
    public static class InputExtensions
    {
        public static T StreamLoop<T>(this T baseInput, int number) where T : BaseInput
        {
            if (number < -1) throw new InvalidRangeException($"{nameof(number)} should be >= -1");
            return baseInput.SetOption("-stream_loop", number.ToString());
        }

        public static T Loop<T>(this T baseInput, int number) where T : BaseInput
        {
            if (number <= 0) throw new InvalidRangeException($"{nameof(number)} <= 0");
            return baseInput.SetOption("-loop", number.ToString());
        }
    }
}
