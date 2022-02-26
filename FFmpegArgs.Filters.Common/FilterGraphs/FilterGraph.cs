namespace FFmpegArgs.Filters.FilterGraphs
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterGraph : IFilterGraph
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IFilter<BaseMap, BaseMap>> Filters { get { return _filters; } }

        internal List<IFilter<BaseMap, BaseMap>> _filters { get; } = new List<IFilter<BaseMap, BaseMap>>();

        /// <summary>
        /// Don't touch
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Index of filter add on success, else throw exception</returns>
        /// <exception cref="InvalidOperationException"></exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int AddFilter(IFilter<BaseMap, BaseMap> filter)
        {
            if(_filters.IndexOf(filter) >= 0)
            {
                throw new InvalidOperationException("this filter was added");
            }
            if (!filter.FilterGraph.Equals(this)) throw new InvalidOperationException("this filter.FilterGraph not same with this FilterGraph");
            _filters.Add(filter);
            return _filters.IndexOf(filter);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="withNewLine">if true, Join filter with <see cref="Environment.NewLine"/></param>
        /// <param name="useChain">Make filter smaller by skipping map [map_name]</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Have map not bind</exception>
        public string GetFiltersArgs(bool withNewLine = false, bool useChain = true)
        {
            var filter_not_bind = Filters.FirstOrDefault(x => x.MapsOut.Any(y => !y.IsMapped));
            if (filter_not_bind != null)
                throw new InvalidOperationException($"Have Map in filter \"{filter_not_bind.FilterName}\" are not bind");
            if (useChain)
            {
                var chains = FilterChain.BuildChains(_filters, true);
                if (withNewLine) return string.Join($";{Environment.NewLine}", chains);
                else return string.Join(";", chains);
            }
            else
            {
                if (withNewLine) return string.Join($";{Environment.NewLine}", _filters);
                else return string.Join(";", _filters);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public string GetFiltersInputArgs()
        {
            var chains = FilterChain.BuildChains(_filters, false);
            if (chains.Count() != 1) throw new InvalidOperationException($"Filter input allow only one chain");
            return chains.First().BuildChain(false, false);
        }
    }
}
