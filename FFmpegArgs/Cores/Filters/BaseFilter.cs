using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters;
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
        public FilterGraph FilterGraph { get; }
        public IEnumerable<TOut> MapsOut { get { return _mapsOut; } }
        public IEnumerable<TIn> MapsIn { get { return _mapsIn; } }
        public TOut MapOut { get { return MapsOut.FirstOrDefault(); } }
        public IEnumerable<KeyValuePair<string, string>> Options { get { return _options; } }

        protected BaseFilter(string filterName, params TIn[] mapsIn)
        {
            if (string.IsNullOrWhiteSpace(filterName)) throw new ArgumentNullException(nameof(filterName));

            var filters = mapsIn.GroupBy(x => x.FilterGraph);
            if (filters.Count() != 1) throw new InvalidOperationException("mapsIn are empty or not same FilterGraph");

            if (mapsIn.Any(x => !x.IsInput && x.IsMapped))
                throw new InvalidOperationException("Map is only \"one to one\", except input");

            this.FilterGraph = filters.First().Key;
            this.FilterName = filterName;

            _mapsIn.AddRange(mapsIn);
            _mapsIn.ForEach(x => x.IsMapped = true);

            this.FilterGraph._filters.Add(this);
            FilterIndex = this.FilterGraph._filters.IndexOf(this);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(FilterName)) throw new NullReferenceException(nameof(FilterName));
            if (_mapsOut.Count == 0) throw new NullReferenceException($"{FilterName} is empty output");

            string inputs = string.Join("", _mapsIn
              .Where(x => !string.IsNullOrWhiteSpace(x.MapName))
              .Select(x => x.IsInput ? $"[{x.MapName}:{(x is ImageMap ? "v" : "a")}:{x.StreamIndex}]" : $"[{x.MapName}]"));

            string outputs = string.Join("", _mapsOut.Select(x => $"[{x.MapName}]"));

            string options = _options.GetFilterOptions();

            if (!string.IsNullOrEmpty(options)) options = "=" + options;
            return $"{inputs}{FilterName}{options}{outputs}";
        }
    }
}
