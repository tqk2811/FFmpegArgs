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
  /// TS. adeclick          A->A       Remove impulsive noise from input audio.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#adeclick
  /// </summary>
  public class AdeclickFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading
  {
    internal AdeclickFilter(AudioMap audioMap) : base("adeclick", audioMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// Set window size, in milliseconds. Allowed range is from 10 to 100. Default value is 55 milliseconds.<br>
    /// </br> This sets size of window which will be processed at once.
    /// </summary>
    /// <param name="window"></param>
    /// <returns></returns>
    public AdeclickFilter Window(float window)
      => this.SetOptionRange("w", window, 10, 100);

    /// <summary>
    /// Set window overlap, in percentage of window size. Allowed range is from 50 to 95. Default value is 75 percent.<br>
    /// </br> Setting this to a very high value increases impulsive noise removal but makes whole process much slower.
    /// </summary>
    /// <param name="overlap"></param>
    /// <returns></returns>
    public AdeclickFilter Overlap(float overlap)
      => this.SetOptionRange("o", overlap, 50, 95);

    /// <summary>
    /// Set autoregression order, in percentage of window size.<br>
    /// </br> Allowed range is from 0 to 25. Default value is 2 percent.<br>
    /// </br> This option also controls quality of interpolated samples using neighbour good samples.
    /// </summary>
    /// <param name="arorder"></param>
    /// <returns></returns>
    public AdeclickFilter ArOrder(float arorder)
      => this.SetOptionRange("a", arorder, 0, 25);

    /// <summary>
    /// Set threshold value. Allowed range is from 1 to 100. <br>
    /// </br>Default value is 2. This controls the strength of impulsive noise which is going to be removed.<br>
    /// </br> The lower value, the more samples will be detected as impulsive noise.
    /// </summary>
    /// <param name="threshold"></param>
    /// <returns></returns>
    public AdeclickFilter Threshold(float threshold)
      => this.SetOptionRange("t", threshold, 1, 100);

    /// <summary>
    /// Set burst fusion, in percentage of window size. Allowed range is 0 to 10.  Default value is 2.<br>
    /// </br> If any two samples detected as noise are spaced less than this value then any sample between those two samples will be also detected as noise.
    /// </summary>
    /// <param name="burst"></param>
    /// <returns></returns>
    public AdeclickFilter Burst(float burst)
      => this.SetOptionRange("b", burst, 0, 10);

    /// <summary>
    /// Set overlap method.
    /// </summary>
    /// <param name="method"></param>
    /// <returns></returns>
    public AdeclickFilter Method(AdeclickMethod method)
      => this.SetOption("m", method.ToString().ToLower());
  }

  public static class AdeclickFilterExtension
  {
    /// <summary>
    /// Remove impulsive noise from input audio.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <returns></returns>
    public static AdeclickFilter AdeclickFilter(this AudioMap audioMap)
    {
      return new AdeclickFilter(audioMap);
    }
  }

  public enum AdeclickMethod
  {
    /// <summary>
    /// Select overlap-add method. Even not interpolated samples are slightly changed with this method.
    /// </summary>
    Add,
    /// <summary>
    /// Select overlap-save method. Not interpolated samples remain unchanged.
    /// </summary>
    Save
  }
}
