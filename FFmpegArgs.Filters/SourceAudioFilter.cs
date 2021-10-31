using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
  public abstract class SourceAudioFilter : BaseFilter<IBaseMap, IAudioMap>
  {
    internal SourceAudioFilter(string filterName, FilterGraph filterGraph)
      : base(filterName, new AudioMap(filterGraph, string.Empty))
    {

    }
  }
}
