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
        protected BaseCodec(Codecs codecName, BaseAVStream stream) : base(stream)
        {
            this.Codec(codecName);
        }
    }
}
