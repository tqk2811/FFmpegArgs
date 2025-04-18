namespace FFmpegArgs.Codec
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCodec : BaseOption, ICodec
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codecName"></param>
        /// <param name="stream"></param>
        protected BaseCodec(string codecName, BaseAVStream stream) : base(stream)
        {
            this.Codec(codecName);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codec"></param>
        /// <param name="stream"></param>
        protected BaseCodec(Codecs codec, BaseAVStream stream) : base(stream)
        {
            this.Codec(codec);
        }
    }
}
