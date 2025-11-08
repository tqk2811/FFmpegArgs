namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class OutputAVStream : BaseAVStream,
        ICodec, ICodecEncoder,
        IStream, IOutputStream
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseMap BaseMap { get; }


        /// <summary>
        /// 
        /// </summary>
        internal OutputAVStream(BaseMap baseMap, int streamIndex) : base(streamIndex)
        {
            this.BaseMap = baseMap ?? throw new ArgumentNullException(nameof(baseMap));
            baseMap.OutputAVStream = this;
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
            yield return "-map";
            if (this.BaseMap.IsInput) yield return this.BaseMap.MapName;
            else yield return $"[{this.BaseMap.MapName}]";
        }
    }
}
