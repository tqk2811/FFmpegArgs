using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// TSC afftdn            A->A       Denoise audio samples using FFT.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#afftdn
  /// </summary>
  public class AfftdnFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
  {
    internal AfftdnFilter(AudioMap audioMap) : base("afftdn", audioMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// Set the noise reduction in dB, allowed range is 0.01 to 97. Default value is 12 dB.
    /// </summary>
    /// <param name="nr"></param>
    /// <returns></returns>
    public AfftdnFilter NR(float nr)
      => this.SetOptionRange("nr", nr, 0.01f, 97);

    /// <summary>
    /// Set the noise floor in dB, allowed range is -80 to -20. Default value is -50 dB.
    /// </summary>
    /// <param name="nf"></param>
    /// <returns></returns>
    public AfftdnFilter NF(float nf)
      => this.SetOptionRange("nf", nf, -80, -20);

    public AfftdnFilter NT(AfftdnNoiseType nt)
      => this.SetOption("nt", nt);

    /// <summary>
    /// Set custom band noise for every one of 15 bands.
    /// </summary>
    /// <param name="bands"></param>
    /// <returns></returns>
    public AfftdnFilter BN(params int[] bands)
      => this.SetOption("bn", string.Join(" ", bands));

    /// <summary>
    /// Set the residual floor in dB, allowed range is -80 to -20. Default value is -38 dB.
    /// </summary>
    /// <param name="rf"></param>
    /// <returns></returns>
    public AfftdnFilter RF(float rf)
      => this.SetOptionRange("rf", rf, -80, -20);

    /// <summary>
    /// Enable noise tracking. By default is disabled. With this enabled, noise floor is automatically adjusted.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public AfftdnFilter TN(bool flag)
      => this.SetOption("tn", flag.ToFFmpegFlag());

    /// <summary>
    /// Enable residual tracking. By default is disabled.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public AfftdnFilter TR(bool flag)
      => this.SetOption("tr", flag.ToFFmpegFlag());

    /// <summary>
    /// Set the output mode.
    /// </summary>
    /// <param name="om"></param>
    /// <returns></returns>
    public AfftdnFilter OM(AfftdnOutputMode om)
     => this.SetOption("om", om);



    //https://ffmpeg.org/ffmpeg-filters.html#Commands-6
  }

  public static class AfftdnFilterExtension
  {
    /// <summary>
    /// Denoise audio samples with FFT.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <returns></returns>
    public static AfftdnFilter AfftdnFilter(this AudioMap audioMap)
    {
      return new AfftdnFilter(audioMap);
    }
  }

  public enum AfftdnNoiseType
  {
    /// <summary>
    /// Select white noise.
    /// </summary>
    w,
    /// <summary>
    /// Select vinyl noise.
    /// </summary>
    v,
    /// <summary>
    /// Select shellac noise.
    /// </summary>
    s,
    /// <summary>
    /// Select custom noise, defined in bn option.
    /// </summary>
    c
  }

  public enum AfftdnOutputMode
  {
    /// <summary>
    /// Pass input unchanged.
    /// </summary>
    i,
    /// <summary>
    /// Pass noise filtered out.
    /// </summary>
    o,
    /// <summary>
    /// Pass only noise.
    /// </summary>
    n
  }
}
