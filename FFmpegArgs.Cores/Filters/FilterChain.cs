namespace FFmpegArgs.Cores.Filters
{
    internal class FilterChain
    {
        readonly List<IFilter> chain = new List<IFilter>();
        internal FilterChain(List<IFilter> chain)
        {
            this.chain = chain ?? throw new ArgumentNullException(nameof(chain));
        }
        public override string ToString() => BuildChain(true, true);
        internal string BuildChain(bool useMapIn, bool useMapOut)
        {
            var first = chain.First();
            var last = chain.Last();
            string inputs = useMapIn ? string.Join("", first.MapsIn
                .Where(x => !string.IsNullOrWhiteSpace(x.MapName))
                .Select(x => $"[{x.MapName}]")) : string.Empty;
            string outputs = useMapOut ? string.Join("", last.MapsOut.Select(x => $"[{x.MapName}]")) : string.Empty;
            string body = string.Join(",", chain.Select(x =>
            {
                string options = x.GetFilterOptions();
                if (!string.IsNullOrEmpty(options)) options = "=" + options;
                return $"{x.FilterName}{options}";
            }));
            return $"{inputs}{body}{outputs}";
        }

        internal static IEnumerable<FilterChain> BuildChains(IEnumerable<IFilter> filters, bool isAllowMultiOut)
        {
            List<IFilter> filters_ = filters.ToList();
            List<List<IFilter>> chains = new List<List<IFilter>>();
            while (true)
            {
                var first_chain = filters_.FirstOrDefault(x => x.MapsIn.Any(y => y.IsInput));//map is input
                if (first_chain == null) first_chain = filters_.FirstOrDefault();//other filter
                if (first_chain == null) break;
                chains.Add(FindChain(filters_, first_chain, isAllowMultiOut));
            }
            return chains.Select(x => new FilterChain(x));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filters">Note: filters.Remove is using</param>
        /// <param name="first"></param>
        /// <param name="isAllowMultiOut"></param>
        /// <returns></returns>
        internal static List<IFilter> FindChain(List<IFilter> filters, IFilter first, bool isAllowMultiOut)
        {
            List<IFilter> chain = new List<IFilter>();
            chain.Add(first);
            filters.Remove(first);//remove used
            while (chain.Last().MapsOut.Count() == 1)//stop at multi output
            {
                var next = filters.FirstOrDefault(x =>
                    x.MapsIn.Count() == 1 && //stop at multi input
                    x.MapsIn.Contains(chain.Last().MapOut) &&//find filter have input == last chain output
                    (isAllowMultiOut || x.MapsOut.Count() == 1));
                if (next == null)
                    break;
                else
                {
                    chain.Add(next);
                    filters.Remove(next);//remove used
                }
            }
            return chain;
        }
    }
}
