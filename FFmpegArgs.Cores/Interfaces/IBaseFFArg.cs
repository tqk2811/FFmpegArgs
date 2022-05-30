namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBaseFFArg
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<BaseInput> Inputs { get; }
    }
}
