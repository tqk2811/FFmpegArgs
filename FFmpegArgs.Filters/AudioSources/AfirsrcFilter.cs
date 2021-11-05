using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFmpegArgs.Filters.AudioFilters;
namespace FFmpegArgs.Filters.AudioSources
{
  /// <summary>
  /// ... afirsrc           |->A       Generate a FIR coefficients audio stream.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#afirsrc
  /// </summary>
  public class AfirsrcFilter : SourceAudioFilter
  {
    internal AfirsrcFilter(FilterGraph filterGraph) : base("afirsrc", filterGraph)
    {
      AddMapOut();
    }

    /// <summary>
    /// Set number of filter coefficents in output audio stream. Default value is 1025.
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public AfirsrcFilter Taps(int t)
      => this.SetOptionRange("t", t, 0, int.MaxValue);

    /// <summary>
    /// Set frequency points from where magnitude and phase are set.<br>
    /// </br> This must be in non decreasing order, and first element must be 0, while last element must be 1. Elements are separated by white spaces.
    /// </summary>
    /// <param name="f"></param>
    /// <returns></returns>
    public AfirsrcFilter Frequency(params int[] f)
      => this.SetOption("f", string.Join(" ", f));

    /// <summary>
    /// Set phase value for every frequency point set by frequency.<br>
    /// </br> Number of values must be same as number of frequency points.<br>
    /// </br> Values are separated by white spaces.
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    public AfirsrcFilter Phase(params int[] p)
     => this.SetOption("p", string.Join(" ",p));

    /// <summary>
    /// Set sample rate, default is 44100.
    /// </summary>
    /// <param name="sample_rate"></param>
    /// <returns></returns>
    public AfirsrcFilter SampleRate(int sample_rate)
      => this.SetOptionRange("r", sample_rate, 0, int.MaxValue);

    /// <summary>
    /// Set number of samples per each frame. Default is 1024.
    /// </summary>
    /// <param name="nb_samples"></param>
    /// <returns></returns>
    public AfirsrcFilter NbSamples(int nb_samples)
      => this.SetOptionRange("n", nb_samples, 0, int.MaxValue);

    /// <summary>
    /// Set window function. Default is blackman.
    /// </summary>
    /// <param name="win_func"></param>
    /// <returns></returns>
    //public AfirsrcFilter win_func( win_func)//need more infomation
  }

  public static class AfirsrcFilterExtensions
  {
    /// <summary>
    /// Generate a FIR coefficients using frequency sampling method.<br></br>
    /// The resulting stream can be used with <see cref="AfirFilter"/> for filtering the audio signal.
    /// </summary>
    /// <returns></returns>
    public static AfirsrcFilter AfirsrcFilter(this FilterGraph filterGraph)
      => new AfirsrcFilter(filterGraph);
  }
}
