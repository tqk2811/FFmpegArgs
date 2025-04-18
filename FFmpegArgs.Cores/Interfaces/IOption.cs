namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOption
    {
        /// <summary>
        /// 
        /// </summary>
        IReadOnlyDictionary<string, string> Options { get; }
    }
}
