using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

// | -> A/V (filter generate) can use it as input
// A/V/N -> A/V/N
//ignore: A/V -> | is for ffplay

namespace FFmpegArgs.Cores.Filters
{
    public abstract class BaseFilter<TIn, TOut> : BaseOption, IFilter<TIn, TOut>
      where TIn : BaseMap, IMap
      where TOut : BaseMap, IMap
    {
        private List<TIn> _mapsIn { get; } = new List<TIn>();
        protected List<TOut> _mapsOut { get; } = new List<TOut>();

        public int FilterIndex { get; }
        public string FilterName { get; }
        public bool IsInput { get; protected set; }
        public FilterGraph FilterGraph { get; }
        public IEnumerable<TOut> MapsOut { get { return _mapsOut; } }
        public IEnumerable<TIn> MapsIn { get { return _mapsIn; } }
        public TOut MapOut { get { return MapsOut.FirstOrDefault(); } }

        protected BaseFilter(string filterName, bool isInput = false, params TIn[] mapsIn)
        {
            if (string.IsNullOrWhiteSpace(filterName)) throw new ArgumentNullException(nameof(filterName));
            if (mapsIn.Any(x => !x.IsInput && x.IsMapped))
                throw new InvalidOperationException("Map is only \"one to one\", except input");
            var filters = mapsIn.GroupBy(x => x.FilterGraph);
            if (filters.Count() != 1) throw new InvalidOperationException("mapsIn are empty or not same FilterGraph");

            this.IsInput = isInput;
            this.FilterGraph = filters.First().Key;
            this.FilterGraph._filters.Add(this);
            this.FilterName = filterName;

            FilterIndex = this.FilterGraph._filters.IndexOf(this);
            _mapsIn.AddRange(mapsIn);
            _mapsIn.ForEach(x => x.IsMapped = true);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FilterName)) throw new NullReferenceException(nameof(FilterName));
            if (_mapsOut.Count == 0) throw new NullReferenceException($"{FilterName} is empty output");
            string inputs = string.Join("", _mapsIn
              .Where(x => !string.IsNullOrWhiteSpace(x.MapName))
              .Select(x => x.IsInput ? $"[{x.MapName}:{(x is ImageMap ? "v" : "a")}:{x.InputIndex}]" : $"[{x.MapName}]"));
            string outputs = string.Join("", _mapsOut.Select(x => $"[{x.MapName}]"));
            string options = string.Join(":", _options.Select(x => $"{x.Key}={x.Value.FiltergraphEscapingLv1()}")).FiltergraphEscapingLv2();
            if (string.IsNullOrEmpty(options)) options = string.Empty;
            else options = "=" + options;
            return $"{inputs}{FilterName}{options}{outputs}";
        }



    }

    /// <summary>
    /// Chain start from BaseFilter.MapsOut.Count == 1
    /// end at BaseFilter.MapsOut.Count > 1
    /// [mapin1][[mapin2]]filter=...,filter=....,filter=....,filter=....[mapout1][[mapout2]]
    /// </summary>
    internal static class FilterChain
    {
        internal static void BuildChain(IEnumerable<BaseFilter<BaseMap, BaseMap>> filters)
        {
            var filters_input = filters.Where(x => x.IsInput);
            var filters_singleOutput = filters.Where(x => x.MapsOut.Count() == 1);//n in, 1 out




        }
    }
}
