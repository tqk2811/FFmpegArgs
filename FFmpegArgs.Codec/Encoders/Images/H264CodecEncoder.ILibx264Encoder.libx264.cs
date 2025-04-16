namespace FFmpegArgs.Codec.Encoders.Images
{
    /// <summary>
    /// 
    /// </summary>
    public class H264_libx264_CodecEncoder : H264CodecEncoder, ILibx264Encoder
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
    }
}
