using System.Collections.Generic;
namespace FFmpegArgs.Cores.Maps
{
  public class VideoMap : IVideoMap
  {
    public IEnumerable<IAudioMap> AudioMaps => _audioMaps;

    public IEnumerable<IImageMap> ImageMaps => _imageMaps;


    readonly List<IAudioMap> _audioMaps = new List<IAudioMap>();
    readonly List<IImageMap> _imageMaps = new List<IImageMap>();
    internal VideoMap(IEnumerable<IImageMap> imageMaps, IEnumerable<IAudioMap> audioMaps)
    {
      _imageMaps.AddRange(imageMaps);
      _audioMaps.AddRange(audioMaps);
    }

  }
}
