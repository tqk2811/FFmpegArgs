using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
  public abstract class AudioToAudioFilter : BaseFilter<IAudioMap, IAudioMap>
  {
    internal AudioToAudioFilter(string filterName, params IAudioMap[] mapsIn) : base(filterName, mapsIn)
    {

    }
  }
}
