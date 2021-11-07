using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// ... aformat           A->A       Convert the input audio to one of the specified formats.
  /// </summary>
  public class AformatFilter : AudioToAudioFilter
  {
    internal AformatFilter(AudioMap audioMap) : base("aformat", audioMap)
    {
      AddMapOut();
    }

#warning Need more info
    /// <summary>
    /// A ’|’-separated list of requested sample formats.
    /// </summary>
    /// <param name="f"></param>
    /// <returns></returns>
    public AformatFilter SampleFmts(params string[] f)
      => this.SetOption("f", string.Join("|", f));

    /// <summary>
    /// A ’|’-separated list of requested sample rates.
    /// </summary>
    /// <param name="r"></param>
    /// <returns></returns>
    public AformatFilter SampleRates(params int[] r)
      => this.SetOption("r", string.Join("|", r));

#warning Need more info
    /// <summary>
    /// A ’|’-separated list of requested channel layouts.<br>
    /// </br>https://ffmpeg.org/ffmpeg-utils.html#channel-layout-syntax
    /// </summary>
    /// <param name="cl"></param>
    /// <returns></returns>
    public AformatFilter ChannelLayouts(params string[] cl)
      => this.SetOption("cl", string.Join("|", cl));
  }

  public static class AformatFilterExtensions
  {
    /// <summary>
    /// Set output format constraints for the input audio. The framework will negotiate the most appropriate format to minimize conversions.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <returns></returns>
    public static AformatFilter AformatFilter(this AudioMap audioMap)
      => new AformatFilter(audioMap);
  }
}
