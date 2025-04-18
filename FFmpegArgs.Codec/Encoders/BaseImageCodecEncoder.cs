namespace FFmpegArgs.Codec.Encoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseImageCodecEncoder : BaseCodecEncoder, ICodec, IImageCodec, ICodecEncoder, IImageCodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseImageCodecEncoder(string codecName, ImageOutputAVStream stream) : base(codecName, stream)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codec"></param>
        /// <param name="stream"></param>
        protected BaseImageCodecEncoder(Codecs codec, ImageOutputAVStream stream) : base(codec, stream)
        {
        }
    }
}
