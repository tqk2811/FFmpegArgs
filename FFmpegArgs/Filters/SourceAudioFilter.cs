using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
    public abstract class SourceAudioFilter : BaseFilter<BaseMap, AudioMap>
    {
        protected SourceAudioFilter(string filterName, FilterGraph filterGraph)
          : base(filterName, new AudioMap(filterGraph, string.Empty))
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
