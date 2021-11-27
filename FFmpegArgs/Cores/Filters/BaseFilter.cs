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
        public bool IsInput { get; } = false;
        public FilterGraph FilterGraph { get; }
        public IEnumerable<TOut> MapsOut { get { return _mapsOut; } }
        public IEnumerable<TIn> MapsIn { get { return _mapsIn; } }
        public TOut MapOut { get { return MapsOut.FirstOrDefault(); } }

        protected BaseFilter(string filterName, bool isInput, params TIn[] mapsIn)
        {
            if (string.IsNullOrWhiteSpace(filterName)) throw new ArgumentNullException(nameof(filterName));

            var filters = mapsIn.GroupBy(x => x.FilterGraph);
            if (filters.Count() != 1) throw new InvalidOperationException("mapsIn are empty or not same FilterGraph");

            if (mapsIn.Any(x => !x.IsInput && x.IsMapped))
                throw new InvalidOperationException("Map is only \"one to one\", except input");

            if(mapsIn.Any(x => x.IsInput && x.InputIndex == -1))
                throw new InvalidOperationException("Invalid InputIndex");

            this.FilterGraph = filters.First().Key;
            this.FilterName = filterName;
            this.IsInput = isInput;

            _mapsIn.AddRange(mapsIn);
            _mapsIn.ForEach(x => x.IsMapped = true);

            this.FilterGraph._filters.Add(this);
            FilterIndex = this.FilterGraph._filters.IndexOf(this);

            if (isInput)
            {
                //
            }
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
    internal class FilterChain
    {
        internal static void BuildChain(IEnumerable<IFilter<IMap, IMap>> filters)
        {
            //chain input
            //var filters_input = filters.Where(x => x.IsInput);
            //List<List<IFilter<IMap, IMap>>> chains = new List<List<IFilter<IMap, IMap>>>();
            //foreach(var filter_input in filters_input)
            //{
            //    //find what filter map 1:1 to that filter_input
            //    List<IFilter<IMap, IMap>> chain = new List<IFilter<IMap, IMap>>();
            //    chain.Add(filter_input);

            //    //only mapin/empty-filter-mapout
            //    while(true)
            //    {
            //        //var next = filters.FirstOrDefault(x => 
            //        //    x.MapsOut.Count() == 1 && 
            //        //    x.MapsIn.Count() == 1 &&
            //        //    x.MapsIn.Contains(chain.Last().MapOut));
            //        //if(next != null) chain.Add(next);
            //        break;
            //    }
            //}

            ////filter non input
            //var filters_nonInput = filters.Except(chains.SelectMany(x => x)).ToList();
            ////map from input
            //var maps_input = filters_nonInput.SelectMany(x => x.MapsIn.Where(y => y.IsInput))
            //    .Concat(chains.Select(x => x.Last().MapOut));


        }
    }
}
