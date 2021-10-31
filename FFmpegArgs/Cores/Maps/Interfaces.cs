using System.Collections.Generic;

namespace FFmpegArgs.Cores.Maps
{
  public interface IBaseMap
  {
    bool IsInput { get; }
    int InputIndex { get; }
    string MapName { get; }
    FilterGraph FilterGraph { get; }
  }
  public interface IAudioMap : IBaseMap
  {
  }
  public interface IImageMap : IBaseMap
  {
  }
  public interface IVideoMap
  {
    IEnumerable<IAudioMap> AudioMaps { get; }
    IEnumerable<IImageMap> ImageMaps { get; }
  }
}
