/*
H264 Decoder AVOptions:
  -is_avc            <boolean>    .D.V..X.... is avc (default false)
  -nal_length_size   <int>        .D.V..X.... nal_length_size (from 0 to 4) (default 0)
  -enable_er         <boolean>    .D.V....... Enable error resilience on damaged frames (unsafe) (default auto)
  -x264_build        <int>        .D.V....... Assume this x264 version if no x264 version found in any SEI (from -1 to INT_MAX) (default -1)
*/
namespace FFmpegArgs.Codec.Decoders.Images
{
    /// <summary>
    /// DEV.LS h264                 H.264 / AVC / MPEG-4 AVC / MPEG-4 part 10<br/>
    /// (decoders: h264 h264_qsv libopenh264 h264_cuvid)<br/>
    /// (encoders: libx264 libx264rgb libopenh264 h264_amf h264_mf h264_nvenc h264_qsv h264_vaapi)
    /// </summary>
    public class H264CodecDecoder : BaseImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264CodecDecoder(ImageInputAVStream stream) : base(Codecs.h264, stream)
        {
        }

        /// <summary>
        /// is avc (default false)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264CodecDecoder IsAvc(bool flag)
            => this.SetOption("-is_avc", flag.ToFFmpegFlag());

        /// <summary>
        /// nal_length_size (from 0 to 4) (default 0)
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public H264CodecDecoder NalLengthSize(int size)
            => this.SetOptionRange("-nal_length_size", size, 0, 4);

        /// <summary>
        /// Enable error resilience on damaged frames (unsafe) (default auto)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public H264CodecDecoder EnableErrorResilience(bool flag)
            => this.SetOption("-enable_er", flag.ToFFmpegFlag());

        /// <summary>
        /// Assume this x264 version if no x264 version found in any SEI (from -1 to INT_MAX) (default -1)
        /// </summary>
        /// <param name="build"></param>
        /// <returns></returns>
        public H264CodecDecoder X264Build(int build)
            => this.SetOptionRange("-x264_build", build, -1, int.MaxValue);
    }

    public static partial class ImageDecoderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static H264CodecDecoder H264Codec(this ImageInputAVStream stream)
            => new H264CodecDecoder(stream);
        public static T H264Codec<T>(this T stream, Action<H264CodecDecoder> action) where T : ImageInputAVStream
        {
            action.Invoke(stream.H264Codec());
            return stream;
        }
    }
}
