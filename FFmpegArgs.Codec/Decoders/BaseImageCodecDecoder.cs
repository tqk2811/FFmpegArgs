namespace FFmpegArgs.Codec.Decoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseImageCodecDecoder : BaseCodecDecoder, ICodec, IImageCodec, ICodecDecoder, IImageCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseImageCodecDecoder(string codecName, ImageInputAVStream stream) : base(codecName, stream)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codec"></param>
        /// <param name="stream"></param>
        protected BaseImageCodecDecoder(Codecs codec, ImageInputAVStream stream) : base(codec, stream)
        {
        }
    }
}
