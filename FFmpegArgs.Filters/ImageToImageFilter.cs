﻿using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters
{
  public abstract class ImageToImageFilter : BaseFilter<IImageMap, IImageMap>
  {
    internal ImageToImageFilter(string filterName, params IImageMap[] mapsIn) : base(filterName, mapsIn)
    {

    }

    protected void AddMapOut()
      => _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}"));
    protected void AddMapOut(int index)
      => _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}_{index}"));
    protected void AddMultiMapOut(int count)
    {
      for (int i = 0; i < count; i++) AddMapOut(i);
    }
  }
}
