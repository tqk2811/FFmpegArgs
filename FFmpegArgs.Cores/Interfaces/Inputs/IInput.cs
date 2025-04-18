namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInput
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<InputAVStream> InputAVStreams { get; }
    }
}
