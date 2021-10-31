using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Cores.Filters
{
  public abstract class BaseFilter<TIn, TOut> : BaseOption, IFilter
    where TIn : IBaseMap
    where TOut : IBaseMap
  {
    protected readonly List<TIn> _mapsIn = new List<TIn>();
    protected readonly List<TOut> _mapsOut = new List<TOut>();

    readonly string FilterName;
    protected int FilterIndex { get; private set; }
    public FilterGraph FilterGraph { get; }
    public IEnumerable<TOut> MapsOut { get { return _mapsOut; } }
    public TOut MapOut { get { return MapsOut.FirstOrDefault(); } }

    protected BaseFilter(string filterName, params TIn[] mapsIn)
    {
      if (string.IsNullOrWhiteSpace(filterName)) throw new ArgumentNullException(nameof(filterName));
      var filters = mapsIn.GroupBy(x => x.FilterGraph);
      if (filters.Count() != 1) throw new InvalidOperationException("mapsIn are empty or not same FilterGraph");
      this.FilterGraph = filters.First().Key;
      this.FilterGraph._filters.Add(this);
      this.FilterName = filterName;

      FilterIndex = this.FilterGraph._filters.IndexOf(this);
      _mapsIn.AddRange(mapsIn);
    }

    public override string ToString()
    {
      if (string.IsNullOrEmpty(FilterName)) throw new NullReferenceException(nameof(FilterName));
      string inputs = string.Join("", _mapsIn
        .Where(x => !string.IsNullOrWhiteSpace(x.MapName))
        .Select(x => x.IsInput ? $"[{x.MapName}:{(x is IImageMap ? "v" : "a")}:{x.InputIndex}]" : $"[{x.MapName}]"));
      string outputs = string.Join("", _mapsOut.Select(x => $"[{x.MapName}]"));
      string options = string.Join(":", _options.Select(x => $"{x.Key}={x.Value}"));
      if (string.IsNullOrEmpty(options)) options = string.Empty;
      else options = "=" + options;
      return $"{inputs}{FilterName}{options}{outputs}";
    }
  }
}
