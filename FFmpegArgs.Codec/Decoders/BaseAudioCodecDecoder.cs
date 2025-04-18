namespace FFmpegArgs.Codec.Decoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseAudioCodecDecoder : BaseCodecDecoder, ICodec, IAudioCodec, ICodecDecoder, IAudioCodecDecoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseAudioCodecDecoder(string codecName, AudioInputAVStream stream) : base(codecName, stream)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codec"></param>
        /// <param name="stream"></param>
        protected BaseAudioCodecDecoder(Codecs codec, AudioInputAVStream stream) : base(codec, stream)
        {
        }
    }
}
