namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class InputAVStream : BaseAVStream,
        ICodec, ICodecDecoder,
        IStream, IInputStream
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseInput BaseInput { get; }

        /// <summary>
        /// 
        /// </summary>
        internal InputAVStream(BaseInput baseInput, int streamIndex) : base(streamIndex)
        {
            this.BaseInput = baseInput ?? throw new ArgumentNullException(nameof(baseInput));
        }

        public override IEnumerable<string> GetAllArgs()
        {
            foreach (var option in base.Options)
            {
                yield return $"{option.Key}:{StreamSymbol}:{StreamIndex}";
                yield return option.Value;
            }
            foreach (var flag in base.Flags)
            {
                yield return flag;
            }
        }
    }
}
