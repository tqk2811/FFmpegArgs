/*
H264 Decoder AVOptions:
  -is_avc            <boolean>    .D.V..X.... is avc (default false)
  -nal_length_size   <int>        .D.V..X.... nal_length_size (from 0 to 4) (default 0)
  -enable_er         <boolean>    .D.V....... Enable error resilience on damaged frames (unsafe) (default auto)
  -x264_build        <int>        .D.V....... Assume this x264 version if no x264 version found in any SEI (from -1 to INT_MAX) (default -1)
*/
namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// DEV.LS h264                 H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10<br/>
    /// (decoders: h264 h264_qsv libopenh264 h264_cuvid)<br/>
    /// (encoders: libx264 libx264rgb libopenh264 h264_amf h264_mf h264_nvenc h264_qsv h264_vaapi)
    /// </summary>
    public class H264CodecEncoder : BaseImageCodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264CodecEncoder(ImageOutputAVStream stream) : base(Codecs.h264, stream)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected H264CodecEncoder(string codecName, ImageOutputAVStream stream) : base(codecName, stream)
        {
        }

    }
    public static partial class ImageEncoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264CodecEncoder H264Codec(this ImageOutputAVStream stream)
            => new H264CodecEncoder(stream);

        /// <summary>
        /// is avc (default false)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T IsAvc<T>(this T t, bool flag) where T : H264CodecEncoder
            => t.SetOption("-is_avc", flag.ToFFmpegFlag());

        /// <summary>
        /// nal_length_size (from 0 to 4) (default 0)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T NalLengthSize<T>(this T t, int size) where T : H264CodecEncoder
            => t.SetOptionRange("-nal_length_size", size, 0, 4);

        /// <summary>
        /// Enable error resilience on damaged frames (unsafe) (default auto)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static T EnableErrorResilience<T>(this T t, bool flag) where T : H264CodecEncoder
            => t.SetOption("-enable_er", flag.ToFFmpegFlag());

        /// <summary>
        /// Assume this x264 version if no x264 version found in any SEI (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="t"></param>
        /// <param name="build"></param>
        /// <returns></returns>
        public static T X264Build<T>(this T t, int build) where T : H264CodecEncoder
            => t.SetOptionRange("-x264_build", build, -1, int.MaxValue);
    }
}