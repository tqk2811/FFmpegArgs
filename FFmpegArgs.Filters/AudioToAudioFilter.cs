using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
  public abstract class AudioToAudioFilter : BaseFilter<AudioMap, AudioMap>
  {
    internal AudioToAudioFilter(string filterName, params AudioMap[] mapsIn) : base(filterName, mapsIn)
    {

    }

    protected void AddMapOut()
      => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}"));
    protected void AddMapOut(int index)
      => _mapsOut.Add(new AudioMap(FilterGraph, $"f_{FilterIndex}_{index}"));
    protected void AddMultiMapOut(int count)
    {
      for (int i = 0; i < count; i++) AddMapOut(i);
    }
  }
}
