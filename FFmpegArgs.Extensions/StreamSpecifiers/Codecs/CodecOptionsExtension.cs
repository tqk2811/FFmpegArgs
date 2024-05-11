namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-all.html#Codec-Options
    /// </summary>
    public static class CodecOptionsExtension
    {
        /// <summary>
        /// Select an encoder (when used before an output file) or a decoder (when used before an input file) for one or more streams. codec is the name of a decoder/encoder or a special value copy (output only) to indicate that the stream is not to be re-encoded.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec"></param>
        /// <returns></returns>
        public static T Codec<T>(this T t, string codec) where T : BaseOption, ICodec // (input/output,per-stream)
           => t.SetOption("-c", codec);
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec"></param>
        /// <returns></returns>
        /// <exception cref="InvalidException"></exception>
        public static T Codec<T>(this T t, Codecs codec) where T : BaseOption, ICodec // (input/output,per-stream)
        {
            CodecFlagAttribute codecFlag = codec.GetEnumAttribute<CodecFlagAttribute>();

            if (t.GetType().IsInstanceOfType(typeof(ICodecEncoding)) && !codecFlag.CheckFlag('E'))
                throw new InvalidException($"Codec '{codec.GetEnumAttribute<NameAttribute>().Name}' is not support encoding");
            if (t.GetType().IsInstanceOfType(typeof(ICodecDecoding)) && !codecFlag.CheckFlag('D'))
                throw new InvalidException($"Codec '{codec.GetEnumAttribute<NameAttribute>().Name}' is not support decoding");
            if (t.GetType().IsInstanceOfType(typeof(IAudio)) && !codecFlag.CheckFlag('A'))
                throw new InvalidException($"Codec '{codec.GetEnumAttribute<NameAttribute>().Name}' is not support audio stream");
            if (t.GetType().IsInstanceOfType(typeof(IImage)) && !codecFlag.CheckFlag('V'))
                throw new InvalidException($"Codec '{codec.GetEnumAttribute<NameAttribute>().Name}' is not support image stream");

            return t.SetOption("-c", codec.GetEnumAttribute<NameAttribute>().Name);
        }


        #region audio,video

        internal static T B<T>(this T t, int bitrate) where T : OutputAVStream, ICodec, ICodecEncoding//encoding,audio,video
            => t.SetOptionRange("-b", bitrate, int.MinValue, int.MaxValue);
        internal static T Maxrate<T>(this T t, int maxrate) where T : OutputAVStream, ICodec, ICodecEncoding//encoding,audio,video
            => t.SetOptionRange("-maxrate", maxrate, int.MinValue, int.MaxValue);
        internal static T Minrate<T>(this T t, int minrate) where T : OutputAVStream, ICodec, ICodecEncoding//encoding,audio,video
            => t.SetOptionRange("-minrate", minrate, int.MinValue, int.MaxValue);
        internal static T Bufsize<T>(this T t, int bufsize) where T : OutputAVStream, ICodec, ICodecEncoding//encoding,audio,video
            => t.SetOptionRange("-bufsize", bufsize, int.MinValue, int.MaxValue);


        //flags flags (decoding/encoding,audio,video,subtitles)
        #endregion



        #region All Codec


        /// <summary>
        /// -frame_number<br></br>Set the frame number.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="frame_number"></param>
        /// <returns></returns>
        public static T FrameNumber<T>(this T t, int frame_number) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-frame_number", frame_number, int.MinValue, int.MaxValue);

        /// <summary>
        /// -delay<br></br>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        public static T Delay<T>(this T t, int delay) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-delay", delay, int.MinValue, int.MaxValue);

        /// <summary>
        /// -codec_tag
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec_tag"></param>
        /// <returns></returns>
        public static T CodecTag<T>(this T t, int codec_tag) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-codec_tag", codec_tag, int.MinValue, int.MaxValue);

        /// <summary>
        /// -has_b_frames<br>
        /// </br>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="has_b_frames"></param>
        /// <returns></returns>
        public static T HasBFrames<T>(this T t, int has_b_frames) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-has_b_frames", has_b_frames, int.MinValue, int.MaxValue);

        /// <summary>
        /// -block_align<br>
        /// </br>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="has_b_frames"></param>
        /// <returns></returns>
        public static T BlockAlign<T>(this T t, int has_b_frames) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-block_align", has_b_frames, int.MinValue, int.MaxValue);

        /// <summary>
        /// -rc_override_count
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="has_b_frames"></param>
        /// <returns></returns>
        public static T RcOverrideCount<T>(this T t, int has_b_frames) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-rc_override_count", has_b_frames, int.MinValue, int.MaxValue);

        /// <summary>
        /// -slice_count
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="slice_count"></param>
        /// <returns></returns>
        public static T SliceCount<T>(this T t, int slice_count) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-slice_count", slice_count, int.MinValue, int.MaxValue);

        /// <summary>
        /// -bits_per_coded_sample
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bits_per_coded_sample"></param>
        /// <returns></returns>
        public static T BitsPerCodedSample<T>(this T t, int bits_per_coded_sample) where T : BaseAVStream, ICodec
            => t.SetOptionRange("-bits_per_coded_sample", bits_per_coded_sample, int.MinValue, int.MaxValue);

        //log_level_offset 

        //pkt_timebase 

        #endregion

    }
}
