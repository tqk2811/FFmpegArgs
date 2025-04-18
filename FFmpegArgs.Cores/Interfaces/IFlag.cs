namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFlag
    {
        /// <summary>
        /// 
        /// </summary>
        IReadOnlyCollection<string> Flags { get; }
    }
}
