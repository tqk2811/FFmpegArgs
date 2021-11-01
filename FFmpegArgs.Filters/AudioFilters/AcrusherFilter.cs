using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  ///  ..C acrusher          A->A       Reduce audio bit resolution.<br>
  ///  </br>https://ffmpeg.org/ffmpeg-filters.html#acrusher (need more info)
  /// </summary>
  public class AcrusherFilter : AudioToAudioFilter
  {
    internal AcrusherFilter(AudioMap audioMap) : base("acrusher", audioMap)
    {
      AddMapOut();
    }
    /// <summary>
    /// Set level in. 
    /// </summary>
    /// <param name="level_in"></param>
    /// <returns></returns>
    public AcrusherFilter LevelIn(string level_in)
      => this.SetOption("level_in", level_in);

    /// <summary>
    /// Set level out.
    /// </summary>
    /// <param name="level_out"></param>
    /// <returns></returns>
    public AcrusherFilter LevelOut(string level_out)
     => this.SetOption("level_out", level_out);

    /// <summary>
    /// Set bit reduction.
    /// </summary>
    /// <param name="bits"></param>
    /// <returns></returns>
    public AcrusherFilter Bits(string bits)
      => this.SetOption("bits", bits);

    /// <summary>
    /// Set mixing amount.
    /// </summary>
    /// <param name="mix"></param>
    /// <returns></returns>
    public AcrusherFilter Mix(string mix)
      => this.SetOption("mix", mix);

    /// <summary>
    /// Can be linear: lin or logarithmic: log.
    /// </summary>
    /// <param name="mode"></param>
    /// <returns></returns>
    public AcrusherFilter Mode(AcrusherMode mode)
      => this.SetOption("mode", mode);

    /// <summary>
    /// Set DC.
    /// </summary>
    /// <param name="dc"></param>
    /// <returns></returns>
    public AcrusherFilter DC(string dc)
     => this.SetOption("dc", dc);

    /// <summary>
    /// Set anti-aliasing.
    /// </summary>
    /// <param name="aa"></param>
    /// <returns></returns>
    public AcrusherFilter AA(string aa)
     => this.SetOption("aa", aa);

    /// <summary>
    /// Set sample reduction.
    /// </summary>
    /// <param name="lforange"></param>
    /// <returns></returns>
    public AcrusherFilter Samples(string lforange)
     => this.SetOption("samples", lforange);

    /// <summary>
    /// Enable LFO. By default disabled.
    /// </summary>
    /// <param name="lfo"></param>
    /// <returns></returns>
    public AcrusherFilter Lfo(bool lfo)
     => this.SetOption("lfo", lfo.ToFFmpegFlag());

    /// <summary>
    /// Set LFO range.
    /// </summary>
    /// <param name="lforange"></param>
    /// <returns></returns>
    public AcrusherFilter LfoRange(string lforange)
    => this.SetOption("lforange", lforange);

    /// <summary>
    /// Set LFO rate.
    /// </summary>
    /// <param name="lforate"></param>
    /// <returns></returns>
    public AcrusherFilter LfoRate(string lforate)
    => this.SetOption("lforate", lforate);
  }

  public static class AcrusherFilterExtension
  {
    /// <summary>
    /// Reduce audio bit resolution.<br>
    /// </br>This filter is bit crusher with enhanced functionality.A bit crusher is used to audibly reduce number of bits an audio signal is sampled with.This doesn’t change the bit depth at all, it just produces the effect.Material reduced in bit depth sounds more harsh and "digital". This filter is able to even round to continuous values instead of discrete bit depths. Additionally it has a D/C offset which results in different crushing of the lower and the upper half of the signal. An Anti-Aliasing setting is able to produce "softer" crushing sounds.<br>
    /// </br>Another feature of this filter is the logarithmic mode.This setting switches from linear distances between bits to logarithmic ones.The result is a much more "natural" sounding crusher which doesn’t gate low signals for example.The human ear has a logarithmic perception, so this kind of crushing is much more pleasant.Logarithmic crushing is also able to get anti-aliased.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <returns></returns>
    public static AcrusherFilter AcrusherFilter(this AudioMap audioMap)
    {
      return new AcrusherFilter(audioMap);
    }
  }

  public enum AcrusherMode
  {
    lin,
    log
  }
}
