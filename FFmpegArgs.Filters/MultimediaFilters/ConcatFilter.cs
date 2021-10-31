using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Filters.MultimediaFilters
{
  /// <summary>
  /// ..C concat            N->N       Concatenate audio and video streams.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#concat
  /// </summary>
  public class ConcatFilter : VideoToVideoFilter, ICommandSupport
  {
    readonly List<ImageMap> _imageMapsOut = new List<ImageMap>();
    readonly List<AudioMap> _audioMapsOut = new List<AudioMap>();

    public IEnumerable<IImageMap> ImageMapsOut { get { return _imageMapsOut; } }
    public IEnumerable<IAudioMap> AudioMapsOut { get { return _audioMapsOut; } }

    /// <summary>
    /// Concatenate audio and video streams, joining them together one after the other.<br>
    /// </br>The filter works on segments of synchronized video and audio streams.All segments must have the same number of streams of each type, and that will also be the number of streams at output.
    /// </summary>
    /// <param name="concatGroups">input: n * (v + a) => output: (v + a)</param>
    public ConcatFilter(IEnumerable<ConcatGroup> concatGroups) : this(concatGroups.ToArray())
    {
    }

    /// <summary>
    /// Concatenate audio and video streams, joining them together one after the other.<br>
    /// </br>The filter works on segments of synchronized video and audio streams.All segments must have the same number of streams of each type, and that will also be the number of streams at output.
    /// </summary>
    /// <param name="concatGroups">input: n * (v + a) => output: (v + a)</param>
    public ConcatFilter(params ConcatGroup[] concatGroups)
      : base("concat", concatGroups.SelectMany(x => x.AllMaps).ToArray())
    {
      if (concatGroups.Length < 2) throw new ArgumentException("concatGroups.Length < 2");
      //check input are same;
      var video_counts = concatGroups.GroupBy(x => x.ImageMaps.Count);
      if (video_counts.Count() != 1) throw new ArgumentException("Number of image per group are not same");

      var audio_counts = concatGroups.GroupBy(x => x.AudioMaps.Count);
      if (audio_counts.Count() != 1) throw new ArgumentException("Number of audio per group are not same");

      int index = 0;
      foreach (var img in concatGroups.First().ImageMaps)
      {
        ImageMap imageMap = new ImageMap(img.FilterGraph, $"f_{FilterIndex}_v{index++}");
        _mapsOut.Add(imageMap);
        _imageMapsOut.Add(imageMap);
      }
      index = 0;
      foreach (var img in concatGroups.First().AudioMaps)
      {
        AudioMap audioMap = new AudioMap(img.FilterGraph, $"f_{FilterIndex}_a{index++}");
        _mapsOut.Add(audioMap);
        _audioMapsOut.Add(audioMap);
      }

      this.SetOption("n", concatGroups.Length);
      this.SetOption("v", concatGroups.First().ImageMaps.Count);
      this.SetOption("a", concatGroups.First().AudioMaps.Count);
    }
  }

  public class ConcatGroup
  {
    public ConcatGroup() { }
    public ConcatGroup(IEnumerable<IImageMap> imageMaps, IEnumerable<IAudioMap> audioMaps)
    {
      ImageMaps.AddRange(imageMaps ?? throw new ArgumentNullException(nameof(imageMaps)));
      AudioMaps.AddRange(audioMaps ?? throw new ArgumentNullException(nameof(audioMaps)));
    }
    public ConcatGroup(IImageMap imageMap, IAudioMap audioMap)
    {
      ImageMaps.Add(imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
      AudioMaps.Add(audioMap ?? throw new ArgumentNullException(nameof(audioMap)));
    }
    public ConcatGroup(params IImageMap[] imageMaps)
    {
      ImageMaps.AddRange(imageMaps ?? throw new ArgumentNullException(nameof(imageMaps)));
    }
    public ConcatGroup(params IAudioMap[] audioMaps)
    {
      AudioMaps.AddRange(audioMaps ?? throw new ArgumentNullException(nameof(audioMaps)));
    }

    public List<IImageMap> ImageMaps { get; } = new List<IImageMap>();
    public List<IAudioMap> AudioMaps { get; } = new List<IAudioMap>();
    internal IEnumerable<IBaseMap> AllMaps { get { return ImageMaps.Cast<IBaseMap>().Concat(AudioMaps); } }
  }
}
