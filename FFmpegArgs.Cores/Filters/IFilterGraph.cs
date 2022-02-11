namespace FFmpegArgs.Cores.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFilterGraph
    {
        /// <summary>
        /// 
        /// </summary>
        IEnumerable<IFilter<BaseMap, BaseMap>> Filters { get; }

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

        /// <summary>
        /// Don't touch
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        int AddFilter(IFilter<BaseMap, BaseMap> filter);
    }
}
