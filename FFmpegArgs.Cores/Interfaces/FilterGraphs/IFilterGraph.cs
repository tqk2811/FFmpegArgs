namespace FFmpegArgs.Cores.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFilterGraph
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<IFilter> Filters { get; }

        internal int AddFilter(IFilter filter);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="withNewLine"></param>
        /// <param name="useChain"></param>
        /// <returns></returns>
        string GetFiltersArgs(bool withNewLine = false, bool useChain = true);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetFiltersInputArgs();
    }
}
