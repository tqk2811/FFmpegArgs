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

        /// <summary>
        /// Limit input read speed.<br>
        /// </br>Its value is a floating-point positive number which represents the maximum duration of media, in seconds, that should be ingested in one second of wallclock time.Default value is zero and represents no imposed limitation on speed of ingestion.Value 1 represents real-time speed and is equivalent to -re.<br>
        /// </br>Mainly used to simulate a capture device or live input stream (e.g.when reading from a file). Should not be used with a low value when input is an actual capture device or live stream as it may cause packet loss.<br>
        /// </br>It is useful for when flow speed of output packets is important, such as live streaming.<br>
        /// </br>-re equal -readrate 1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseInput"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public static T ReadRate<T>(this T baseInput, float rate = 1) where T : BaseInput
            => baseInput.SetOptionRange("-readrate", rate, 0, float.MaxValue);

        /// <summary>
        /// -re equal -readrate 1
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="baseInput"></param>
        /// <returns></returns>
        public static T Re<T>(this T baseInput) where T : BaseInput
            => baseInput.ReadRate(1);
    }
}
