﻿using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// ... alphaextract      V->N       Extract an alpha channel as a grayscale image component.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#alphaextract
  /// </summary>
  public class AlphaextractFilter : ImageToImageFilter
  {
    internal AlphaextractFilter(ImageMap imageMap) : base("alphaextract", imageMap)
    {
      AddMapOut();
      base.IsAllowEmptyOption = true;
    }
  }

  public static class AlphaextractFilterExtensions
  {
    /// <summary>
    /// Extract the alpha component from the input as a grayscale video. This is especially useful with the alphamerge filter.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <returns></returns>
    public static AlphaextractFilter AlphaextractFilter(this ImageMap imageMap)
      => new AlphaextractFilter(imageMap);
  }
}
