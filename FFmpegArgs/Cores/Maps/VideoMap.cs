using System.Collections.Generic;
namespace FFmpegArgs.Cores.Maps
{
  public class VideoMap
  {
    public IEnumerable<AudioMap> AudioMaps => _audioMaps;

    public IEnumerable<ImageMap> ImageMaps => _imageMaps;


    readonly List<AudioMap> _audioMaps = new List<AudioMap>();
    readonly List<ImageMap> _imageMaps = new List<ImageMap>();
    internal VideoMap(IEnumerable<ImageMap> imageMaps, IEnumerable<AudioMap> audioMaps)
    {
      _imageMaps.AddRange(imageMaps);
      _audioMaps.AddRange(audioMaps);
    }

  }
}
