using FFmpegArgs.Cores.Maps;
using System;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// .S. acrossover        A->N       Split audio into per-bands streams.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#acrossover
  /// </summary>
  public class AcrossoverFilter : AudioToAudioFilter
  {
    internal AcrossoverFilter(int[] hzSplit, AudioMap audioMap) : base("acrossover", audioMap)
    {
      this.SetOption("split", string.Join(" ", hzSplit));
      AddMultiMapOut(hzSplit.Length + 1);
    }

    /// <summary>
    /// Set filter order for each band split. This controls filter roll-off or steepness of filter transfer function
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public AcrossoverFilter Order(AcrossoverOrder order)
      => this.SetOption("order", order.ToString().Substring(1));

    /// <summary>
    /// Set input gain level. Allowed range is from 0 to 1. Default value is 1.
    /// </summary>
    /// <param name="level"></param>
    /// <returns></returns>
    public AcrossoverFilter Level(float level)
      => this.SetOptionRange("level", level, 0, 1);

    /// <summary>
    /// Set output gain for each band. Default value is 1 for all bands.
    /// </summary>
    /// <param name="gains"></param>
    /// <returns></returns>
    public AcrossoverFilter Gains(int gains)
       => this.SetOptionRange("gains", gains, 0, int.MaxValue);
  }

  public static class AcrossoverFilterExtension
  {
    /// <summary>
    /// Split audio stream into several bands.<br>
    /// </br>This filter splits audio stream into two or more frequency ranges.Summing all streams back will give flat output.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <param name="hzSplit">Set split frequencies. Those must be positive and increasing.</param>
    /// <returns></returns>
    public static AcrossoverFilter AcrossoverFilter(this AudioMap audioMap, params int[] hzSplit)
    {
      if (hzSplit.Length == 0) throw new ArgumentNullException(nameof(hzSplit));
      return new AcrossoverFilter(hzSplit, audioMap);
    }
  }

  public enum AcrossoverOrder
  {
    /// <summary>
    /// 12 dB per octave.
    /// </summary>
    _2nd,

    /// <summary>
    /// 24 dB per octave.
    /// </summary>
    _4th,

    /// <summary>
    /// 36 dB per octave.
    /// </summary>
    _6th,

    /// <summary>
    /// 48 dB per octave.
    /// </summary>
    _8th,

    /// <summary>
    /// 60 dB per octave.
    /// </summary>
    _10th,

    /// <summary>
    /// 72 dB per octave.
    /// </summary>
    _12th,

    /// <summary>
    /// 84 dB per octave.
    /// </summary>
    _14th,

    /// <summary>
    /// 96 dB per octave.
    /// </summary>
    _16th,

    /// <summary>
    /// 108 dB per octave.
    /// </summary>
    _18th,

    /// <summary>
    /// 120 dB per octave.
    /// </summary>
    _20th
  }
}
