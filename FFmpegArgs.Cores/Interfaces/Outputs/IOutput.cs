namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOutput : IMux
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<OutputAVStream> Streams { get; }
    }
}
