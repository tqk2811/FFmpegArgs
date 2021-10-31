using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
  public abstract class SourceImageFilter : BaseFilter<IBaseMap, IImageMap>
  {
    internal SourceImageFilter(string filterName, FilterGraph filterGraph)
      : base(filterName, new ImageMap(filterGraph, string.Empty))
    {

    }
  }
}
