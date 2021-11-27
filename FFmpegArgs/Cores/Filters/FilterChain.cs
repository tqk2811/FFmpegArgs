using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

// | -> A/V (filter generate) can use it as input
// A/V/N -> A/V/N
//ignore: A/V -> | is for ffplay

namespace FFmpegArgs.Cores.Filters
{
    /// <summary>
    /// Chain start from BaseFilter.MapsOut.Count == 1
    /// end at BaseFilter.MapsOut.Count > 1
    /// [mapin1][[mapin2]]filter=...,filter=....,filter=....,filter=....[mapout1][[mapout2]]
    /// </summary>
    internal class FilterChain
    {
        readonly List<IFilter<IMap, IMap>> chain = new List<IFilter<IMap, IMap>>();

        internal FilterChain(List<IFilter<IMap, IMap>> chain)
        {
            this.chain = chain ?? throw new ArgumentNullException(nameof(chain));
        }

        public override string ToString() => BuildChain(true);

        internal string BuildChain(bool useMap)
        {
            var first = chain.First();
            var last = chain.Last();

            string inputs = string.Join("", first.MapsIn
              .Where(x => !string.IsNullOrWhiteSpace(x.MapName))
              .Select(x => x.IsInput ? $"[{x.MapName}:{(x is ImageMap ? "v" : "a")}:{x.StreamIndex}]" : $"[{x.MapName}]"));

            string outputs = useMap ? string.Join("", last.MapsOut.Select(x => $"[{x.MapName}]")) : string.Empty;

            string body = string.Join(",", chain.Select(x =>
            {
                string options = string.Join(":", x.Options.Select(x => $"{x.Key}={x.Value.FiltergraphEscapingLv1()}")).FiltergraphEscapingLv2();
                if (!string.IsNullOrEmpty(options)) options = "=" + options;
                return $"{x.FilterName}{options}";
            }));

            return $"{inputs}{body}{outputs}";
        }


        internal static IEnumerable<FilterChain> BuildChains(IEnumerable<IFilter<IMap, IMap>> filters)
        {
            List<IFilter<IMap, IMap>> filters_ = filters.ToList();
            List<List<IFilter<IMap, IMap>>> chains = new List<List<IFilter<IMap, IMap>>>();

            while (true)
            {
                var first_chain = filters_.FirstOrDefault(x => x.MapsIn.Any(y => y.IsInput));//map is input
                if (first_chain == null) first_chain = filters_.FirstOrDefault();//other filter
                if (first_chain == null) break;

                chains.Add(FindChain(filters_, first_chain, true));
            }

            return chains.Select(x => new FilterChain(x));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filters">Note: filters.Remove is using</param>
        /// <param name="first"></param>
        /// <returns></returns>
        internal static List<IFilter<IMap, IMap>> FindChain(List<IFilter<IMap, IMap>> filters, IFilter<IMap, IMap> first, bool isAllowMultiOut)
        {
            List<IFilter<IMap, IMap>> chain = new List<IFilter<IMap, IMap>>();
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
