using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// T.C afade             A->A       Fade in/out input audio.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#afade-1
  /// </summary>
  public class AfadeFilter : AudioToAudioFilter, ITimelineSupport, ICommandSupport
  {
    internal AfadeFilter(IAudioMap audioMap) : base("afade", audioMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// Specify the effect type, can be either in for fade-in, or out for a fade-out effect. Default is in.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public AfadeFilter Type(AfadeType type)
    => this.SetOption("t", type.ToString().ToLower());

    /// <summary>
    /// Specify the number of the start sample for starting to apply the fade effect. Default is 0.
    /// </summary>
    /// <param name="start_sample"></param>
    /// <returns></returns>
    public AfadeFilter StartSample(int start_sample)
       => this.SetOption("ss", start_sample);

    /// <summary>
    /// Specify the number of samples for which the fade effect has to last. At the end of the fade-in effect the output audio will have the same volume as the input audio, at the end of the fade-out transition the output audio will be silence. Default is 44100.
    /// </summary>
    /// <param name="nb_samples"></param>
    /// <returns></returns>
    public AfadeFilter NbSamples(int nb_samples)
       => this.SetOption("ns", nb_samples);

    /// <summary>
    /// Specify the start time of the fade effect. Default is 0. The value must be specified as a time duration.<br>
    /// </br> If set this option is used instead of start_sample.
    /// </summary>
    /// <param name="st"></param>
    /// <returns></returns>
    public AfadeFilter StartTime(double st)
       => this.SetOption("st", st);

    /// <summary>
    /// Specify the duration of the fade effect. At the end of the fade-in effect the output audio will have the same volume as the input audio, at the end of the fade-out transition the output audio will be silence. By default the duration is determined by nb_samples. If set this option is used instead of nb_samples.
    /// </summary>
    /// <param name="duration"></param>
    /// <returns></returns>
    public AfadeFilter Duration(double duration)
     => this.SetOption("d", duration);

    /// <summary>
    /// Set curve for fade transition.
    /// </summary>
    /// <param name="curve"></param>
    /// <returns></returns>
    public AfadeFilter Curve(AfadeCurve curve)
     => this.SetOption("curve", curve.ToString());
  }


  public static class AfadeFilterExtension
  {
    /// <summary>
    /// Apply fade-in/out effect to input audio.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <returns></returns>
    public static AfadeFilter AfadeFilter(this IAudioMap audioMap)
    {
      return new AfadeFilter(audioMap);
    }
  }

  public enum AfadeType
  {
    In,
    Out
  }

  public enum AfadeCurve
  {
    /// <summary>
    /// select triangular, linear slope (default)
    /// </summary>
    tri,

    /// <summary>
    /// select quarter of sine wave
    /// </summary>
    qsin,

    /// <summary>
    /// select half of sine wave
    /// </summary>
    hsin,

    /// <summary>
    /// select exponential sine wave
    /// </summary>
    esin,

    /// <summary>
    /// select logarithmic
    /// </summary>
    log,

    /// <summary>
    /// select inverted parabola
    /// </summary>
    ipar,

    /// <summary>
    /// select quadratic
    /// </summary>
    qua,

    /// <summary>
    /// select cubic
    /// </summary>
    cub,

    /// <summary>
    /// select square root
    /// </summary>
    squ,

    /// <summary>
    /// select cubic root
    /// </summary>
    cbr,

    /// <summary>
    /// select parabola
    /// </summary>
    par,

    /// <summary>
    /// select exponential
    /// </summary>
    exp,

    /// <summary>
    /// select inverted quarter of sine wave
    /// </summary>
    iqsin,

    /// <summary>
    /// select inverted half of sine wave
    /// </summary>
    ihsin,

    /// <summary>
    /// select double-exponential seat
    /// </summary>
    dese,

    /// <summary>
    /// select double-exponential sigmoid
    /// </summary>
    desi,

    /// <summary>
    /// select logistic sigmoid
    /// </summary>
    losi,

    /// <summary>
    /// select sine cardinal function
    /// </summary>
    sinc,

    /// <summary>
    /// select inverted sine cardinal function
    /// </summary>
    isinc,

    /// <summary>
    /// no fade applied
    /// </summary>
    nofade,
  }
}
