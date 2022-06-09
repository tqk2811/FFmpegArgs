namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-all.html#Codec-Options
    /// </summary>
    public static class CodecOptionsExtension
    {
        #region audio,video

        internal static T B<T>(this T t, int bitrate) where T : OutputAVStream//encoding,audio,video
            => t.SetOptionRange("-b", bitrate, int.MinValue, int.MaxValue);
        internal static T Maxrate<T>(this T t, int maxrate) where T : OutputAVStream//encoding,audio,video
            => t.SetOptionRange("-maxrate", maxrate, int.MinValue, int.MaxValue);
        internal static T Minrate<T>(this T t, int minrate) where T : OutputAVStream//encoding,audio,video
            => t.SetOptionRange("-minrate", minrate, int.MinValue, int.MaxValue);
        internal static T Bufsize<T>(this T t, int bufsize) where T : OutputAVStream//encoding,audio,video
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
        public static T FrameNumber<T>(this T t, int frame_number) where T : BaseAVStream
            => t.SetOptionRange("-frame_number", frame_number, int.MinValue, int.MaxValue);

        /// <summary>
        /// -delay<br></br>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        public static T Delay<T>(this T t, int delay) where T : BaseAVStream
            => t.SetOptionRange("-delay", delay, int.MinValue, int.MaxValue);

        /// <summary>
        /// -codec_tag
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="codec_tag"></param>
        /// <returns></returns>
        public static T CodecTag<T>(this T t, int codec_tag) where T : BaseAVStream
            => t.SetOptionRange("-codec_tag", codec_tag, int.MinValue, int.MaxValue);

        /// <summary>
        /// -has_b_frames<br>
        /// </br>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="has_b_frames"></param>
        /// <returns></returns>
        public static T HasBFrames<T>(this T t, int has_b_frames) where T : BaseAVStream
            => t.SetOptionRange("-has_b_frames", has_b_frames, int.MinValue, int.MaxValue);

        /// <summary>
        /// -block_align<br>
        /// </br>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="has_b_frames"></param>
        /// <returns></returns>
        public static T BlockAlign<T>(this T t, int has_b_frames) where T : BaseAVStream
            => t.SetOptionRange("-block_align", has_b_frames, int.MinValue, int.MaxValue);

        /// <summary>
        /// -rc_override_count
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="has_b_frames"></param>
        /// <returns></returns>
        public static T RcOverrideCount<T>(this T t, int has_b_frames) where T : BaseAVStream
            => t.SetOptionRange("-rc_override_count", has_b_frames, int.MinValue, int.MaxValue);

        /// <summary>
        /// -slice_count
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="slice_count"></param>
        /// <returns></returns>
        public static T SliceCount<T>(this T t, int slice_count) where T : BaseAVStream
            => t.SetOptionRange("-slice_count", slice_count, int.MinValue, int.MaxValue);

        /// <summary>
        /// -bits_per_coded_sample
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bits_per_coded_sample"></param>
        /// <returns></returns>
        public static T BitsPerCodedSample<T>(this T t, int bits_per_coded_sample) where T : BaseAVStream
            => t.SetOptionRange("-bits_per_coded_sample", bits_per_coded_sample, int.MinValue, int.MaxValue);

        //log_level_offset 

        //pkt_timebase 
        
        #endregion

    }
}
