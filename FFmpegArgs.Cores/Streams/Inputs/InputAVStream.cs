namespace FFmpegArgs.Cores.Streams
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class InputAVStream : BaseAVStream
    {
        /// <summary>
        /// 
        /// </summary>
        public int StreamIndex { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public BaseInput BaseInput { get; }

        /// <summary>
        /// 
        /// </summary>
        protected InputAVStream(BaseInput baseInput, int streamIndex)
        {
            if (streamIndex < 0) throw new ArgumentOutOfRangeException(nameof(streamIndex));
            this.BaseInput = baseInput ?? throw new ArgumentNullException(nameof(baseInput));
            this.StreamIndex = streamIndex;
        }
    }
}
