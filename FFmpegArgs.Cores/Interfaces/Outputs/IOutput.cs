namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOutput
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<OutputAVStream> OutputAVStreams { get; }
    }
}
