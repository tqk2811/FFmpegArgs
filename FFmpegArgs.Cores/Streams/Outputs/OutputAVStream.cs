namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class OutputAVStream : BaseAVStream
    {
        /// <summary>
        /// 
        /// </summary>
        public BaseMap BaseMap { get; }


        /// <summary>
        /// 
        /// </summary>
        protected OutputAVStream(BaseMap baseMap)
        {
            this.BaseMap = baseMap ?? throw new ArgumentNullException(nameof(baseMap));
            baseMap.OutputAVStream = this;
        }
    }
}
