using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// TSC atadenoise        V->V       Apply an Adaptive Temporal Averaging Denoiser.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#atadenoise
  /// </summary>
  public class AtadenoiseFilter : ImageToImageFilter , ITimelineSupport, ISliceThreading, ICommandSupport
  {
    internal AtadenoiseFilter(ImageMap imageMap) : base("atadenoise", imageMap)
    {
      AddMapOut();
      IsAllowEmptyOption = true;
    }

    public AtadenoiseFilter ThressholdA(AtadenoiseThresholdA a, float val)
      => this.SetOptionRange(a.ToString().Substring(1), val, 0, 0.3);

    public AtadenoiseFilter ThressholdB(AtadenoiseThresholdB b, float val)
      => this.SetOptionRange(b.ToString().Substring(1), val, 0, 5);

    /// <summary>
    /// Set number of frames filter will use for averaging.<br>
    /// </br> Default is 9. Must be odd number in range [5, 129].
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public AtadenoiseFilter NumberOfFrames(int s)
      => this.SetOptionRange("s", s.IsOdd(), 5, 129);

#warning Need more info
    /// <summary>
    /// Set what planes of frame filter will use for averaging. Default is all.
    /// </summary>
    /// <param name="planes"></param>
    /// <returns></returns>
    public AtadenoiseFilter Planes(string planes)
      => this.SetOption("p", planes);

#warning Need more info
    /// <summary>
    /// Set what variant of algorithm filter will use for averaging. Default is p parallel. Alternatively can be set to s serial.<br></br>
    /// Parallel can be faster then serial, while other way around is never true. Parallel will abort early on first change being greater then thresholds, while serial will continue processing other side of frames if they are equal or below thresholds.
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public AtadenoiseFilter VariantOfAlgorithm(string a)
      => this.SetOption("a", a);


    /// <summary>
    /// Set sigma for 1st plane, 2nd plane or 3rd plane. <br>
    /// </br>Default is 32767. Valid range is from 0 to 32767. This options controls weight for each pixel in radius defined by size.<br>
    /// </br> Default value means every pixel have same weight. Setting this option to 0 effectively disables filtering.
    /// </summary>
    /// <param name="sigma"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public AtadenoiseFilter Sigma(AtadenoiseSigma sigma, int val)
      => this.SetOptionRange(sigma.ToString().Substring(1), val, 0, 32767);
  }

  public static class AtadenoiseFilterExtensions
  {
    public static AtadenoiseFilter AtadenoiseFilter(this ImageMap imageMap)
      => new AtadenoiseFilter(imageMap);
  }

  public enum AtadenoiseThresholdA
  {
    /// <summary>
    /// Set threshold A for 1st plane. Default is 0.02. Valid range is 0 to 0.3.
    /// </summary>
    _0a,
    /// <summary>
    /// Set threshold A for 2nd plane. Default is 0.02. Valid range is 0 to 0.3.
    /// </summary>
    _1a,
    /// <summary>
    /// Set threshold A for 3rd plane. Default is 0.02. Valid range is 0 to 0.3.
    /// </summary>
    _2a,
  }
  public enum AtadenoiseThresholdB
  {
    /// <summary>
    /// Set threshold B for 1st plane. Default is 0.04. Valid range is 0 to 5.
    /// </summary>
    _0b,
    /// <summary>
    /// Set threshold B for 2nd plane. Default is 0.04. Valid range is 0 to 5.
    /// </summary>
    _1b,
    /// <summary>
    /// Set threshold B for 3rd plane. Default is 0.04. Valid range is 0 to 5.
    /// </summary>
    _2b,
  }

  public enum AtadenoiseSigma
  {
    _0s,
    _1s,
    _2s
  }
}
