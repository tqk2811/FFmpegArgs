namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class H264_libx264rgb_CodecEncoder : BaseImageCodecEncoder, IH264_libx264_Encoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        public H264_libx264rgb_CodecEncoder(ImageOutputAVStream stream) : base("libx264rgb", stream)
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
        public static H264_libx264rgb_CodecEncoder H264_libx264rgb_Codec(this ImageOutputAVStream stream)
            => new H264_libx264rgb_CodecEncoder(stream);
    }
}
