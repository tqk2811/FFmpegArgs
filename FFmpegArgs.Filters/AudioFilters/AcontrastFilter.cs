using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  ///  ... acontrast         A->A       Simple audio dynamic range compression/expansion filter.<br></br>
  ///  https://ffmpeg.org/ffmpeg-filters.html#acontrast
  /// </summary>
  public class AcontrastFilter : AudioToAudioFilter
  {
    internal AcontrastFilter(float contrast, IAudioMap audioMap) : base("acontrast", audioMap)
    {
      if (contrast < 0 || contrast > 100) throw new InvalidRangeException($"0 <= level_in <= 100");
      this.SetOption("contrast", contrast);
      AddMapOut();
    }
  }

  public static class AcontrastFilterExtension
  {
    /// <summary>
    /// Simple audio dynamic range compression/expansion filter.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <param name="contrast">Set contrast. Default is 33. Allowed range is between 0 and 100.</param>
    /// <returns></returns>
    public static AcontrastFilter AcontrastFilter(this IAudioMap audioMap, float contrast)
    {
      return new AcontrastFilter(contrast, audioMap);
    }
  }
}
