using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// ... acue              A->A       Delay filtering to match a cue.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#acue
  /// </summary>
  public class AcueFilter : AudioToAudioFilter
  {
    internal AcueFilter(AudioMap audioMap) : base("acue", audioMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// The cue timestamp expressed in a UNIX timestamp in microseconds. Default is 0.
    /// </summary>
    /// <param name="cue"></param>
    /// <returns></returns>
    public AcueFilter Cue(long cue)
      => this.SetOptionRange("cue", cue, 0, long.MaxValue);

    /// <summary>
    /// The duration of content to pass on as preroll expressed in seconds. Default is 0.
    /// </summary>
    /// <param name="preroll"></param>
    /// <returns></returns>
    public AcueFilter Preroll(int preroll)
      => this.SetOptionRange("preroll", preroll, 0, long.MaxValue);

    /// <summary>
    /// The maximum duration of content to buffer before waiting for the cue expressed in seconds. Default is 0.
    /// </summary>
    /// <param name="buffer"></param>
    /// <returns></returns>
    public AcueFilter Buffer(long buffer)
      => this.SetOptionRange("buffer", buffer, 0, long.MaxValue);
  }

  public static class AcueFilterExtension
  {
    /// <summary>
    /// Delay audio filtering until a given wallclock timestamp. See the <see cref="CueFilter"/>.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <returns></returns>
    public static AcueFilter AcueFilter(this AudioMap audioMap)
    {
      return new AcueFilter(audioMap);
    }
  }
}
