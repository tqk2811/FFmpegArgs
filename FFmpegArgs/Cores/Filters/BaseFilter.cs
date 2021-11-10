using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Cores.Filters
{
  public abstract class BaseFilter<TIn, TOut> : BaseFilterOption
    where TIn : BaseMap
    where TOut : BaseMap
  {
    private List<TIn> _mapsIn { get; } = new List<TIn>();
    protected List<TOut> _mapsOut { get; } = new List<TOut>();

    readonly string FilterName;
    protected int FilterIndex { get; private set; }
    protected bool IsAllowEmptyOption { get; set; } = false;
    public FilterGraph FilterGraph { get; }
    public IEnumerable<TOut> MapsOut { get { return _mapsOut; } }
    public TOut MapOut { get { return MapsOut.FirstOrDefault(); } }

    protected BaseFilter(string filterName, params TIn[] mapsIn)
    {
      if (string.IsNullOrWhiteSpace(filterName)) throw new ArgumentNullException(nameof(filterName));
      if (mapsIn.Any(x => !x.IsInput && x.IsMapped))
        throw new InvalidOperationException("Map is only \"one to one\", except input");
      var filters = mapsIn.GroupBy(x => x.FilterGraph);
      if (filters.Count() != 1) throw new InvalidOperationException("mapsIn are empty or not same FilterGraph");
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
      string options = string.Join(":", _options.Select(x => $"{x.Key}={x.Value}"));
      if (string.IsNullOrEmpty(options))
      {
        if (IsAllowEmptyOption) options = string.Empty;
        else throw new NullReferenceException($"{FilterName} is empty option");
      }
      else options = "=" + options;
      return $"{inputs}{FilterName}{options}{outputs}";
    }
  }
}
