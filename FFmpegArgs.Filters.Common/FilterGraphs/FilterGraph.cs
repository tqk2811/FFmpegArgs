namespace FFmpegArgs.Filters.FilterGraphs
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterGraph : BaseFilterGraph
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="withNewLine">if true, Join filter with <see cref="Environment.NewLine"/></param>
        /// <param name="useChain">Make filter smaller by skipping map [map_name]</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">Have map not bind</exception>
        public override string GetFiltersArgs(bool withNewLine = false, bool useChain = true)
        {
            var filter_not_bind = Filters.FirstOrDefault(x => x.MapsOut.Any(y => !y.IsMapped));
            if (filter_not_bind != null)
                throw new InvalidOperationException($"Have Map in filter \"{filter_not_bind.FilterName}\" are not bind");
            if (useChain)
            {
                var chains = FilterChain.BuildChains(Filters, true);
                if (withNewLine) return string.Join($";{Environment.NewLine}", chains);
                else return string.Join(";", chains);
            }
            else
            {
                if (withNewLine) return string.Join($";{Environment.NewLine}", Filters);
                else return string.Join(";", Filters);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public override string GetFiltersInputArgs()
        {
            var chains = FilterChain.BuildChains(Filters, false);
            if (chains.Count() != 1) throw new InvalidOperationException($"Filter input allow only one chain");
            return chains.First().BuildChain(false, false);
        }
    }
}
