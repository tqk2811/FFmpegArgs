using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
namespace FFmpegArgs
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterGraph
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<IFilter<IMap, IMap>> Filters { get { return _filters; } }
        internal List<IFilter<IMap, IMap>> _filters { get; } = new List<IFilter<IMap, IMap>>();
        /// <summary>
        /// 
        /// </summary>
        public FilterGraph()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="withNewLine">if true, Join filter with <see cref="Environment.NewLine"/></param>
        /// <param name="useChain">Make filter smaller by skipping map [map_name]</param>
        /// <returns></returns>
        /// <exception cref="FilterException">Have map not bind</exception>
        public string GetFiltersArgs(bool withNewLine = false, bool useChain = true)
        {
            var filter_not_bind = Filters.FirstOrDefault(x => x.MapsOut.Any(y => !y.IsMapped));
            if (filter_not_bind != null)
                throw new FilterException($"Have Map in filter \"{filter_not_bind.FilterName}\" are not bind");
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
