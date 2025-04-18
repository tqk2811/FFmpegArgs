namespace FFmpegArgs.Codec.Decoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCodecDecoder : BaseCodec, ICodec, ICodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseCodecDecoder(string codecName, InputAVStream stream) : base(codecName, stream)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codec"></param>
        /// <param name="stream"></param>
        protected BaseCodecDecoder(Codecs codec, BaseAVStream stream) : base(codec, stream)
        {

        }
    }
}
