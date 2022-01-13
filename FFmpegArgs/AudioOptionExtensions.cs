using FFmpegArgs.Cores;
using System;
namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg.html#Main-options
    /// </summary>
    public static class AudioOptionExtensions
    {
        /// <summary>
        /// Set the audio sampling frequency. For output streams it is set by default to the frequency of the corresponding input stream. For input streams this option only makes sense for audio grabbing devices and raw demuxers and is mapped to the corresponding demuxer options.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="swsFlags"></param>
        /// <returns></returns>
        public static T Freq<T>(this T t, int freq, int? stream_specifier = null) where T : BaseInputOutput, IAudio
        {
            if (stream_specifier == null)
            {
                t.SetOptionRange($"-ar", freq, 0, int.MaxValue);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                t.SetOptionRange($"-ar:{stream_specifier.Value}", freq, 0, int.MaxValue);
            }
            return t;
        }
        /// <summary>
        /// Set the number of audio channels. For output streams it is set by default to the number of input audio channels. For input streams this option only makes sense for audio grabbing devices and raw demuxers and is mapped to the corresponding demuxer options.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="channels"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Channels<T>(this T t, int channels, int? stream_specifier = null) where T : BaseInputOutput, IAudio
        {
            if (stream_specifier == null)
            {
                t.SetOptionRange($"-ac", channels, 0, int.MaxValue);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                t.SetOptionRange($"-ac:{stream_specifier.Value}", channels, 0, int.MaxValue);
            }
            return t;
        }
        public static T AN<T>(this T t) where T : BaseInputOutput, IAudio
            => t.SetFlag("-an");
        public static T ACodec<T>(this T t, string acodec) where T : BaseInputOutput, IAudio
           => t.SetOption("-acodec", acodec);
    }
}
