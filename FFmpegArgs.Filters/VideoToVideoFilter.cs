using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
  public abstract class VideoToVideoFilter : BaseFilter<IBaseMap, IBaseMap>
  {
    internal VideoToVideoFilter(string filterName, params IBaseMap[] baseMaps) : base(filterName, baseMaps)
    {

    }
  }
}
