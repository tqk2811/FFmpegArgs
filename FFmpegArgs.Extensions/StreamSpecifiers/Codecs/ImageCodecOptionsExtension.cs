namespace FFmpegArgs
{
    /// <summary>
    /// https://ffmpeg.org/ffmpeg-all.html#Codec-Options
    /// </summary>
    public static class ImageCodecOptionsExtension
    {
        #region audio,video

        /// <summary>
        /// -b<br></br>Set bitrate in bits/s. Default value is 200K.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bitrate"></param>
        /// <returns></returns>
        public static T B<T>(this T t, int bitrate) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,audio,video
            => CodecOptionsExtension.B(t, bitrate);

        /// <summary>
        /// -maxrate<br>
        /// </br>Set max bitrate tolerance (in bits/s). Requires bufsize to be set.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="maxrate"></param>
        /// <returns></returns>
        public static T Maxrate<T>(this T t, int maxrate) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,audio,video
            => CodecOptionsExtension.Maxrate(t, maxrate);

        /// <summary>
        /// -minrate<br>
        /// </br>Set min bitrate tolerance (in bits/s). Most useful in setting up a CBR encode. It is of little use elsewise.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="minrate"></param>
        /// <returns></returns>
        public static T Minrate<T>(this T t, int minrate) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,audio,video
            => CodecOptionsExtension.Minrate(t, minrate);

        /// <summary>
        /// -bufsize<br>
        /// </br>Set ratecontrol buffer size (in bits).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bufsize"></param>
        /// <returns></returns>
        public static T Bufsize<T>(this T t, int bufsize) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,audio,video
            => CodecOptionsExtension.Bufsize(t, bufsize);
        #endregion



        /// <summary>
        /// -g<br></br>Set the group of picture (GOP) size. Default value is 12.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="g"></param>
        /// <returns></returns>
        public static T G<T>(this T t, int g) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
            => t.SetOptionRange("-g", g, int.MinValue, int.MaxValue);

        /// <summary>
        /// -qcomp<br>
        /// </br>Set video quantizer scale compression (VBR). It is used as a constant in the ratecontrol equation. Recommended range for default rc_eq: 0.0-1.0.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="qcomp"></param>
        /// <returns></returns>
        public static T Qcomp<T>(this T t, float qcomp) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
           => t.SetOptionRange("-qcomp", qcomp, 0.0f, 1.0f);

        /// <summary>
        /// -qblur<br>
        /// </br>Set video quantizer scale blur (VBR).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="qcomp"></param>
        /// <returns></returns>
        public static T Qblur<T>(this T t, float qcomp) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
           => t.SetOptionRange("-qblur", qcomp, 0.0f, 1.0f);

        /// <summary>
        /// -qmin<br>
        /// </br>Set min video quantizer scale (VBR). Must be included between -1 and 69, default value is 2.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="qmin"></param>
        /// <returns></returns>
        public static T Qmin<T>(this T t, int qmin) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
           => t.SetOptionRange("-qmin", qmin, -1, 69);

        /// <summary>
        /// -qmax<br>
        /// </br>Set max video quantizer scale (VBR). Must be included between -1 and 1024, default value is 31.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="qmax"></param>
        /// <returns></returns>
        public static T Qmax<T>(this T t, int qmax) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
           => t.SetOptionRange("-qmax", qmax, -1, 1024);

        /// <summary>
        /// -qdiff<br>
        /// </br>Set max difference between the quantizer scale (VBR).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="qdiff"></param>
        /// <returns></returns>
        public static T Qdiff<T>(this T t, int qdiff) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
           => t.SetOptionRange("-qdiff", qdiff, int.MinValue, int.MaxValue);

        /// <summary>
        /// -bf<br>
        /// </br>Set max number of B frames between non-B-frames.<br>
        /// </br>Must be an integer between -1 and 16. 0 means that B-frames are disabled.If a value of -1 is used, it will choose an automatic value depending on the encoder.<br>
        /// </br>Default value is 0.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="bf"></param>
        /// <returns></returns>
        public static T Bf<T>(this T t, int bf) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
           => t.SetOptionRange("-bf", bf, -1, 16);

        /// <summary>
        /// -b_qfactor<br>
        /// </br>Set qp factor between P and B frames.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="b_qfactor"></param>
        /// <returns></returns>
        public static T BQfactor<T>(this T t, float b_qfactor) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
            => t.SetOptionRange("-b_qfactor", b_qfactor, 0.0f, 1.0f);

        // bug flags (decoding,video)

        //public static T Strict<T>(this T t, int strict) where T : BaseAVStream, IImage//decoding/encoding,audio,video
        //   => t.SetOptionRange("-strict", strict, 0.0f, 1.0f);

        /// <summary>
        /// -b_qoffset<br>
        /// </br>Set QP offset between P and B frames.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="b_qoffset"></param>
        /// <returns></returns>
        public static T BQoffset<T>(this T t, float b_qoffset) where T : OutputAVStream, ICodec, ICodecEncoding, IImage//encoding,video
            => t.SetOptionRange("-b_qoffset", b_qoffset, 0.0f, 1.0f);

        //err_detect flags (decoding,audio,video)
    }
}
