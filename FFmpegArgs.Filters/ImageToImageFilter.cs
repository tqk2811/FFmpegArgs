using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
  public abstract class ImageToImageFilter : BaseFilter<IImageMap, IImageMap>
  {
    internal ImageToImageFilter(string filterName, params IImageMap[] mapsIn) : base(filterName, mapsIn)
    {

    }
  }
}
