namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class H264_libx264_CodecEncoder : BaseImageCodecEncoder, IH264_libx264_Encoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264_libx264_CodecEncoder(ImageOutputAVStream stream) : base("libx264", stream)
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
        public static H264_libx264_CodecEncoder H264_libx264_Codec(this ImageOutputAVStream stream)
            => new H264_libx264_CodecEncoder(stream);
        public static T H264_libx264_Codec<T>(this T stream, Action<H264_libx264_CodecEncoder> action) where T : ImageOutputAVStream
        {
            action.Invoke(stream.H264_libx264_Codec());
            return stream;
        }
    }
}
