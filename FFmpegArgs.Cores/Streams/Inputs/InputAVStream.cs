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
        public BaseInput BaseInput { get; }

        /// <summary>
        /// 
        /// </summary>
        internal InputAVStream(BaseInput baseInput, int streamIndex) : base(streamIndex)
        {
            this.BaseInput = baseInput ?? throw new ArgumentNullException(nameof(baseInput));
        }
    }
}
