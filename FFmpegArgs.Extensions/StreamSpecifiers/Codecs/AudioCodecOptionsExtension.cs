namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-all.html#Codec-Options
    /// </summary>
    public static class AudioCodecOptionsExtension
    {
        #region audio,video

        /// <summary>
        /// -b<br></br>Set bitrate in bits/s. Default value is 200K.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bitrate"></param>
        /// <returns></returns>
        public static T B<T>(this T t, int bitrate) where T : OutputAVStream, ICodec, ICodecEncoder, IAudio//encoding,audio,video
            => CodecOptionsExtension.B(t, bitrate);
        /// <summary>
        /// -b<br></br>Set bitrate in bits/s. Default value is 200K.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bitrate"></param>
        /// <returns></returns>
        public static T B<T>(this T t, long bitrate) where T : OutputAVStream, ICodec, ICodecEncoding, IAudio//encoding,audio,video
            => CodecOptionsExtension.B(t, bitrate);

        /// <summary>
        /// -maxrate<br>
        /// </br>Set max bitrate tolerance (in bits/s). Requires bufsize to be set.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="maxrate"></param>
        /// <returns></returns>
        public static T Maxrate<T>(this T t, int maxrate) where T : OutputAVStream, ICodec, ICodecEncoder, IAudio//encoding,audio,video
            => CodecOptionsExtension.Maxrate(t, maxrate);

        /// <summary>
        /// -minrate<br>
        /// </br>Set min bitrate tolerance (in bits/s). Most useful in setting up a CBR encode. It is of little use elsewise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="minrate"></param>
        /// <returns></returns>
        public static T Minrate<T>(this T t, int minrate) where T : OutputAVStream, ICodec, ICodecEncoder, IAudio//encoding,audio,video
            => CodecOptionsExtension.Minrate(t, minrate);

        /// <summary>
        /// -bufsize<br>
        /// </br>Set ratecontrol buffer size (in bits).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bufsize"></param>
        /// <returns></returns>
        public static T Bufsize<T>(this T t, int bufsize) where T : OutputAVStream, ICodec, ICodecEncoder, IAudio//encoding,audio,video
            => CodecOptionsExtension.Bufsize(t, bufsize);
        #endregion





        /// <summary>
        /// -ar<br></br>Set audio sampling rate (in Hz).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="hz"></param>
        /// <returns></returns>
        public static T Ar<T>(this T t, int hz) where T : BaseAVStream, ICodec, IAudio//decoding/encoding,audio
            => t.SetOptionRange("-ar", hz, -1, int.MaxValue);

        /// <summary>
        /// -ac<br></br>Set number of audio channels.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="ac"></param>
        /// <returns></returns>
        public static T Ac<T>(this T t, int ac) where T : BaseAVStream, ICodec, IAudio//decoding/encoding,audio
            => t.SetOptionRange("-ac", ac, -1, int.MaxValue);

        /// <summary>
        /// -cutoff<br></br>Set cutoff bandwidth. (Supported only by selected encoders, see their respective documentation sections.)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public static T CutOff<T>(this T t, int cutoff) where T : OutputAVStream, ICodec, ICodecEncoder, IAudio//encoding,audio
            => t.SetOptionRange("-cutoff", cutoff, -1, int.MaxValue);

        /// <summary>
        /// -frame_size<br>
        /// </br>Set audio frame size.<br>
        /// </br>Each submitted frame except the last must contain exactly frame_size samples per channel.May be 0 when the codec has CODEC_CAP_VARIABLE_FRAME_SIZE set, in that case the frame size is not restricted.It is set by some decoders to indicate constant frame size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="frame_size"></param>
        /// <returns></returns>
        public static T FrameSize<T>(this T t, int frame_size) where T : OutputAVStream, ICodec, ICodecEncoder, IAudio//encoding,audio
            => t.SetOptionRange("-frame_size", frame_size, -1, int.MaxValue);
    }
}
