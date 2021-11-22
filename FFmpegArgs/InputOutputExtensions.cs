using FFmpegArgs.Cores;
using System;

namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg.html#Main-options
    /// </summary>
    public static class InputOutputExtensions
    {
        /// <summary>
        /// Force input or output file format. The format is normally auto detected for input files and guessed from the file extension for output files, so this option is not needed in most cases.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fmt"></param>
        /// <returns></returns>
        public static T Fmt<T>(this T t, string fmt) where T : BaseInputOutput
          => t.SetOption("-f", fmt);

        /// <summary>
        /// Select an encoder (when used before an output file) or a decoder (when used before an input file) for one or more streams. codec is the name of a decoder/encoder or a special value copy (output only) to indicate that the stream is not to be re-encoded.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T VCodec<T>(this T t, string codec, int? stream_specifier = null) where T : BaseInputOutput, IImage
        {
            if (stream_specifier == null)
            {
                t.SetOption($"-c:v", codec);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                t.SetOption($"-c:v:{stream_specifier.Value}", codec);
            }
            return t;
        }


        /// <summary>
        /// Select an encoder (when used before an output file) or a decoder (when used before an input file) for one or more streams. codec is the name of a decoder/encoder or a special value copy (output only) to indicate that the stream is not to be re-encoded.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T ACodec<T>(this T t, string codec, int? stream_specifier = null) where T : BaseInputOutput, IAudio
        {
            if (stream_specifier == null)
            {
                t.SetOption($"-c:a", codec);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                t.SetOption($"-c:a:{stream_specifier.Value}", codec);
            }
            return t;
        }

        /// <summary>
        /// When used as an input option (before -i), limit the duration of data read from the input file.<br>
        /// </br>When used as an output option(before an output url), stop writing the output after its duration reaches duration.<br>
        /// </br>-to and -t are mutually exclusive and -t has priority.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static T Duration<T>(this T t, TimeSpan duration) where T : BaseInputOutput
            => t.SetOptionRange("-t", duration, TimeSpan.Zero, TimeSpan.MaxValue);


        /// <summary>
        /// Stop writing the output or reading the input at position. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static T ToPosition<T>(this T t, TimeSpan position) where T : BaseInputOutput
            => t.SetOptionRange("-to", position, TimeSpan.Zero, TimeSpan.MaxValue);

        /// <summary>
        /// When used as an input option (before -i), seeks in this input file to position. Note that in most formats it is not possible to seek exactly, so ffmpeg will seek to the closest seek point before position. When transcoding and -accurate_seek is enabled (the default), this extra segment between the seek point and position will be decoded and discarded. When doing stream copy or when -noaccurate_seek is used, it will be preserved.<br>
        /// </br>When used as an output option(before an output url), decodes but discards input until the timestamps reach position.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static T SsPosition<T>(this T t, TimeSpan position) where T : BaseInputOutput
            => t.SetOptionRange("-ss", position, TimeSpan.Zero, TimeSpan.MaxValue);


        /// <summary>
        /// As an input option, blocks all data streams of a file from being filtered or being automatically selected or mapped for any output. See -discard option to disable streams individually.<br>
        /// </br>As an output option, disables data recording i.e.automatic selection or mapping of any data stream.For full manual control see the -map option.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T DN<T>(this T t) where T : BaseInputOutput
            => t.SetFlag("-dn");
    }
}
