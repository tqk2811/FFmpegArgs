using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Cores.Filters
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterGraph : IFilterGraph, IImageFilterGraph, IAudioFilterGraph
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IFilter> Filters { get { return _filters; } }

        readonly List<IFilter> _filters = new List<IFilter>();

        int AddFilter(IFilter filter)
        {
            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            if (_filters.IndexOf(filter) >= 0)
                throw new InvalidOperationException("this filter was added");

            if (!this.Equals(filter.FilterGraph))
                throw new InvalidOperationException("this filter.FilterGraph not same with this FilterGraph");


            _filters.Add(filter);
            return _filters.IndexOf(filter);
        }

        int IFilterGraph.AddFilter(IFilter filter) => AddFilter(filter);
        int IImageFilterGraph.AddFilter<TIn, TOut>(BaseFilter<TIn, TOut> filter) => AddFilter(filter);
        int IAudioFilterGraph.AddFilter<TIn, TOut>(BaseFilter<TIn, TOut> filter) => AddFilter(filter);


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
        public string GetFiltersInputArgs()
        {
            var chains = FilterChain.BuildChains(Filters, false);
            if (chains.Count() != 1) throw new InvalidOperationException($"Filter input allow only one chain");
            return chains.First().BuildChain(false, false);
        }

    }
}
