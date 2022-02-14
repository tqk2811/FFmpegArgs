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
        /// <exception cref="FilterException">Have map not bind</exception>
        string GetFiltersArgs(bool withNewLine = false, bool useChain = true);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        string GetFiltersInputArgs();

        /// <summary>
        /// Don't touch
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Index of filter add on success, else throw exception</returns>
        /// <exception cref="InvalidOperationException"></exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        int AddFilter(IFilter<BaseMap, BaseMap> filter);
    }
}
