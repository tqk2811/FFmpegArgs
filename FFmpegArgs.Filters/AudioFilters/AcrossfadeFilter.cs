using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// ... acrossfade        AA->A      Cross fade two input audio streams.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#acrossfade
  /// </summary>
  public class AcrossfadeFilter : AudioToAudioFilter
  {
    internal AcrossfadeFilter(params AudioMap[] audioMaps) : base("acrossfade", audioMaps)
    {
      AddMapOut();
    }

    /// <summary>
    /// Specify the number of samples for which the cross fade effect has to last.<br>
    /// </br> At the end of the cross fade effect the first input audio will be completely silent.<br>
    /// </br> Default is 44100.
    /// </summary>
    /// <param name="ns"></param>
    /// <returns></returns>
    public AcrossfadeFilter NbSamples(int ns)
      => this.SetOption("ns", ns);

    /// <summary>
    /// Specify the duration of the cross fade effect.<br>
    /// </br> By default the duration is determined by nb_samples.<br>
    /// </br> If set this option is used instead of nb_samples.
    /// </summary>
    /// <param name="duration">total seconds</param>
    /// <returns></returns>
    public AcrossfadeFilter Duration(double duration)
      => this.SetOption("d", duration);

    /// <summary>
    /// Should first stream end overlap with second stream start. Default is enabled.
    /// </summary>
    /// <param name="overlap"></param>
    /// <returns></returns>
    public AcrossfadeFilter Overlap(bool overlap)
      => this.SetOption("o", overlap.ToFFmpegFlag());

    /// <summary>
    /// Set curve for cross fade transition for first stream.
    /// </summary>
    /// <param name="overlap"></param>
    /// <returns></returns>
    public AcrossfadeFilter curve1(AfadeCurve curve)
      => this.SetOption("curve1", curve.ToString());

    /// <summary>
    /// Set curve for cross fade transition for second stream.
    /// </summary>
    /// <param name="overlap"></param>
    /// <returns></returns>
    public AcrossfadeFilter curve2(AfadeCurve curve)
      => this.SetOption("curve2", curve.ToString());
  }

  public static class AcrossfadeFilterExtension
  {
    /// <summary>
    /// Apply cross fade from one input audio stream to another input audio stream.<br>
    /// </br> The cross fade is applied for specified duration near the end of first stream.
    /// </summary>
    /// <returns></returns>
    public static AcrossfadeFilter AcrossfadeFilter(this AudioMap audioMap, AudioMap audioMap1)
    {
      return new AcrossfadeFilter(audioMap, audioMap1);
    }
  }
}
