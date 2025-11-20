namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInput : IDemux
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<InputAVStream> Streams { get; }
    }
}
