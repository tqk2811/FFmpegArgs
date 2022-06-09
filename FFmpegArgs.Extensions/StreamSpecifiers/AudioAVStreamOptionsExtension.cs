namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg.html#Audio-Options<br>
    /// </br>https://ffmpeg.org/ffmpeg.html#Advanced-Audio-options
    /// </summary>
    public static class AudioAVStreamOptionsExtension
    {
        #region Audio Options
        /// <summary>
        /// Set the number of audio frames to output. This is an obsolete alias for -frames:a, which you should use instead.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="aframes"></param>
        /// <returns></returns>
        public static T Aframes<T>(this T t, int aframes) where T : BaseOutput, IAudio // (output)
            => t.SetOptionRange("-aframes", aframes, 0, int.MaxValue);

        /// <summary>
        /// Set the audio sampling frequency. For output streams it is set by default to the frequency of the corresponding input stream. For input streams this option only makes sense for audio grabbing devices and raw demuxers and is mapped to the corresponding demuxer options.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="freq"></param>
        /// <returns></returns>
        public static T Ar<T>(this T t, int freq) where T : BaseAVStream, IAudio // (input/output,per-stream)
            => t.SetOptionRange("-ar", freq, 0, int.MaxValue);

        /// <summary>
        /// Set the audio quality (codec-specific, VBR). This is an alias for -q:a.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="aq"></param>
        /// <returns></returns>
        public static T Aq<T>(this T t, string aq) where T : BaseOutput, IAudio // (output)
            => t.SetOption("-aq", aq);

        /// <summary>
        /// Set the number of audio channels. For output streams it is set by default to the number of input audio channels. For input streams this option only makes sense for audio grabbing devices and raw demuxers and is mapped to the corresponding demuxer options.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="ac"></param>
        /// <returns></returns>
        public static T Ac<T>(this T t, int ac) where T : BaseAVStream, IAudio // (input/output,per-stream)
            => t.SetOptionRange("-ac", ac, 0, int.MaxValue);

        /// <summary>
        /// As an input option, blocks all audio streams of a file from being filtered or being automatically selected or mapped for any output. See -discard option to disable streams individually.<br>
        /// </br>As an output option, disables audio recording i.e.automatic selection or mapping of any audio stream.For full manual control see the -map option.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static T An<T>(this T t) where T : BaseInputOutput, IAudio // (input/output)
            => t.SetFlag("-an");

        /// <summary>
        /// et the audio codec. This is an alias for -codec:a.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec"></param>
        /// <returns></returns>
        public static T Acodec<T>(this T t, string codec) where T : BaseInputOutput, IAudio // (input/output)
            => t.SetOption("-acodec", codec);

        /// <summary>
        /// Set the audio sample format. Use -sample_fmts to get a list of supported sample formats.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="sample_fmt"></param>
        /// <returns></returns>
        public static T SampleFmt<T>(this T t, AVSampleFormat sample_fmt) where T : AudioOutputAVStream // (output,per-stream)
            => t.SetOption("-sample_fmt", sample_fmt.GetEnumAttribute<NameAttribute>().Name);

        // -af filtergraph (output)
        #endregion


        #region Advance Audio Options
        /// <summary>
        /// Force audio tag/fourcc. This is an alias for -tag:a.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="atag"></param>
        /// <returns></returns>
        public static T Atag<T>(this T t, string atag) where T : BaseOutput
            => t.SetOption("-atag", atag);

        // -absf bitstream_filter

        /// <summary>
        /// If some input channel layout is not known, try to guess only if it corresponds to at most the specified number of channels.For example, 2 tells to ffmpeg to recognize 1 channel as mono and 2 channels as stereo but not 6 channels as 5.1. The default is to always try to guess. Use 0 to disable all guessing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="channels"></param>
        /// <returns></returns>
        public static T GuessLayoutMax<T>(this T t, int channels) where T : AudioInputAVStream // (input,per-stream)
            => t.SetOption("-guess_layout_max", channels);
        #endregion
    }
}
