namespace FFmpegArgs.Outputs
{
    /// <summary>
    /// 
    /// </summary>
    public static class OutputExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static T Format<T>(this T t, MuxingFileFormat format) where T : BaseOutput
            => t.SetOption("-f", format.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        /// Set the file size limit, expressed in bytes. No further chunk of bytes is written after the limit is exceeded. The size of the output file is slightly more than the requested file size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="limit_size"></param>
        /// <returns></returns>
        public static T LimitSize<T>(this T t, long limit_size) where T : BaseOutput
            => t.SetOptionRange("-fs", limit_size, 1, long.MaxValue);
        /// <summary>
        /// Set the recording timestamp in the container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="localdate"></param>
        /// <returns></returns>
        public static T Timestamp<T>(this T t, DateTime localdate) where T : BaseOutput
            => t.SetOption("-timestamp", localdate.ToString("YYYYMMDD HHMMSS"));
        /// <summary>
        /// Specify target file type (vcd, svcd, dvd, dv, dv50). type may be prefixed with pal-, ntsc- or film- to use the corresponding standard. All the format options (bitrate, codecs, buffer sizes) are then set automatically. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static T Target<T>(this T output, string type) where T : BaseOutput
          => output.SetOption("-target", type);
        /// <summary>
        /// Set the number of data frames to output. This is an obsolete alias for -frames:d, which you should use instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="dframes"></param>
        /// <returns></returns>
        public static T Dframes<T>(this T output, int dframes) where T : BaseOutput
          => output.SetOption("-dframes", dframes);
        /// <summary>
        /// Stop writing to the stream after framecount frames.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="framecount"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Framecount<T>(this T output, long framecount, int? stream_specifier = null) where T : BaseOutput
        {
            if (stream_specifier == null)
            {
                output.SetOptionRange("-frames", framecount, 0, long.MaxValue);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                output.SetOptionRange($"-frames:{stream_specifier.Value}", framecount, 0, long.MaxValue);
            }
            return output;
        }
        /// <summary>
        /// Use fixed quality scale (VBR). The meaning of q/qscale is codec-dependent. If qscale is used without a stream_specifier then it applies only to the video stream, this is to maintain compatibility with previous behavior and as specifying the same codec specific value to 2 different codecs that is audio and video generally is not what is intended when no stream_specifier is used.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="qscale"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Qscale<T>(this T output, string qscale, int? stream_specifier = null) where T : BaseOutput
        {
            if (stream_specifier == null)
            {
                output.SetOption("-q", qscale);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                output.SetOption($"-q:{stream_specifier.Value}", qscale);
            }
            return output;
        }
        /// <summary>
        /// Set the number of video frames to output. This is an obsolete alias for -frames:v, which you should use instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="vsync"></param>
        /// <returns></returns>
        public static T Vframes<T>(this T output, int vsync) where T : BaseOutput, IImage
            => output.SetOption("-vframes", vsync);
        /// <summary>
        /// Set maximum frame rate (Hz value, fraction or abbreviation).<br>
        /// </br>Clamps output frame rate when output framerate is auto-set and is higher than this value.Useful in batch processing or when input framerate is wrongly detected as very high.It cannot be set together with -r.It is ignored during streamcopy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="fps"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Fpsmax<T>(this T output, int fps, int? stream_specifier = null) where T : BaseOutput, IImage
        {
            if (stream_specifier == null)
            {
                output.SetOptionRange("-fpsmax", fps, 0, int.MaxValue);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                output.SetOptionRange($"-fpsmax:{stream_specifier.Value}", fps, 0, int.MaxValue);
            }
            return output;
        }
        /// <summary>
        /// Set the video display aspect ratio specified by aspect.<br>
        /// </br>aspect can be a floating point number string, or a string of the form num:den, where num and den are the numerator and denominator of the aspect ratio.For example "4:3", "16:9", "1.3333", and "1.7777" are valid argument values.<br>
        /// </br>If used together with -vcodec copy, it will affect the aspect ratio stored at container level, but not the aspect ratio stored in encoded frames, if it exists.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="aspect"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T Aspect<T>(this T output, Rational aspect, int? stream_specifier = null) where T : BaseOutput, IImage
        {
            if (stream_specifier == null)
            {
                output.SetOption("-aspect", aspect);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                output.SetOption($"-aspect:{stream_specifier.Value}", aspect);
            }
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="codec"></param>
        /// <returns></returns>
        public static T VCodec<T>(this T output, string codec) where T : BaseOutput, IImage
            => output.SetOption("-vcodec", codec);
        /// <summary>
        /// Video sync method. For compatibility reasons old values can be specified as numbers. Newly added values will have to be specified as strings always.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="vsync"></param>
        /// <returns></returns>
        public static T VSync<T>(this T output, VSyncMethod vsync) where T : BaseOutput, IImage
            => output.SetOption("-vsync", vsync);

        /// <summary>
        /// Set the number of audio frames to output. This is an obsolete alias for -frames:a, which you should use instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="aframes"></param>
        /// <returns></returns>
        public static T Aframes<T>(this T output, int aframes) where T : BaseOutput, IAudio
            => output.SetOption("-aframes", aframes);
        /// <summary>
        /// Set the audio quality (codec-specific, VBR). This is an alias for -q:a.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static T AQ<T>(this T output, string q) where T : BaseOutput, IAudio
           => output.SetOption("-aq", q);
        /// <summary>
        /// Set the audio sample format. Use -sample_fmts to get a list of supported sample formats.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="sample_fmt"></param>
        /// <param name="stream_specifier"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T SampleFmt<T>(this T output, string sample_fmt, int? stream_specifier = null) where T : BaseOutput, IAudio
        {
            if (stream_specifier == null)
            {
                output.SetOption("-sample_fmt", sample_fmt);
            }
            else
            {
                if (stream_specifier.Value < 0) throw new ArgumentOutOfRangeException($"Range Required: {0} <= {stream_specifier}");
                output.SetOption($"-sample_fmt:{stream_specifier.Value}", sample_fmt);
            }
            return output;
        }
        /// <summary>
        /// Audio sync method. "Stretches/squeezes" the audio stream to match the timestamps, the parameter is the maximum samples per second by which the audio is changed. -async 1 is a special case where only the start of the audio stream is corrected without any later correction.<br>
        /// </br>Note that the timestamps may be further modified by the muxer, after this. For example, in the case that the format option avoid_negative_ts is enabled.<br>
        /// </br>This option has been deprecated.Use the aresample audio filter instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="output"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        public static T ASync<T>(this T output, int async) where T : BaseOutput, IAudio
            => output.SetOption("-async", async);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bitRate"></param>
        /// <returns></returns>
        public static T VideoBitrate<T>(this T t, long bitRate) where T : BaseOutput, IImage
            => t.SetOptionRange("-b:v", bitRate, 1, long.MaxValue);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bitRate"></param>
        /// <returns></returns>
        public static T AudioBitrate<T>(this T t, long bitRate) where T : BaseOutput, IAudio
            => t.SetOptionRange("-b:a", bitRate, 1, long.MaxValue);
    }
}
