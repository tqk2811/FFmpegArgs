namespace FFmpegArgs.Cores
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseInputOutput : BaseArgsOptionFlag
    {
        /// <summary>
        /// Pipe for input/output
        /// </summary>
        public virtual Stream? PipeStream { get; }

        public abstract IEnumerable<string> GetAVStreamArgs();
    }
}
