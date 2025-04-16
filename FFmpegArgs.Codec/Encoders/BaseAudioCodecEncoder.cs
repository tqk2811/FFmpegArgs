namespace FFmpegArgs.Codec.Encoders
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseAudioCodecEncoder : BaseCodecEncoder, ICodec, IAudioCodec, ICodecEncoder, IAudioCodecEncoder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseAudioCodecEncoder(string codecName, AudioOutputAVStream stream) : base(codecName, stream)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codec"></param>
        /// <param name="stream"></param>
        protected BaseAudioCodecEncoder(Codecs codec, AudioOutputAVStream stream) : base(codec, stream)
        {
        }
    }
}
