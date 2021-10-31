using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.AudioFilters
{
  /// <summary>
  /// T.C volume            A->A       Change input volume. <br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#volume
  /// </summary>
  public class VolumeFilter : AudioToAudioFilter, ITimelineSupport
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "n",
      "nb_channels",
      "nb_consumed_samples",
      "nb_samples",
      "pos",
      "pts",
      "sample_rate",
      "startpts",
      "startt",
      "t",
      "tb",
      "volume"
    };
    readonly Expression expression = new Expression(_variables);
    internal VolumeFilter(Action<Expression> volume, IAudioMap audioMap) : base("volume", audioMap)
    {
      AddMapOut();
      this.SetOption("volume", volume.Run(expression));
    }


    /// <summary>
    /// This parameter represents the mathematical precision.<br>
    /// </br>It determines which input sample formats will be allowed, which affects the precision of the volume scaling.
    /// </summary>
    /// <param name="precision"></param>
    /// <returns></returns>
    public VolumeFilter Precision(VolumeNumberPrecision precision)
      => this.SetOption("precision", precision.ToString().ToLower());

    /// <summary>
    /// Choose the behaviour on encountering ReplayGain side data in input frames.
    /// </summary>
    /// <param name="replayGain"></param>
    /// <returns></returns>
    public VolumeFilter ReplayGain(VolumeReplayGain replayGain)
      => this.SetOption("replaygain", replayGain.ToString().ToLower());

    /// <summary>
    /// Set when the volume expression is evaluated.
    /// </summary>
    /// <param name="eval"></param>
    /// <returns></returns>
    public VolumeFilter Eval(VolumeEval eval)
       => this.SetOption("eval", eval.ToString().ToLower());

    /// <summary>
    /// Pre-amplification gain in dB to apply to the selected replaygain gain.<br></br>
    /// Default value for replaygain_preamp is 0.0.
    /// </summary>
    /// <param name="replaygain_preamp"></param>
    /// <returns></returns>
    public VolumeFilter ReplaygainPreamp(float replaygain_preamp)
    {
      //check??
      return this.SetOption("replaygain_preamp", replaygain_preamp);
    }

    /// <summary>
    /// Prevent clipping by limiting the gain applied.<br></Br>
    /// Default value for replaygain_noclip is 1.
    /// </summary>
    /// <param name="replaygain_noclip"></param>
    /// <returns></returns>
    public VolumeFilter ReplaygainNoclip(float replaygain_noclip)
    {
      //check??
      return this.SetOption("replaygain_noclip", replaygain_noclip);
    }
  }

  public static class VolumeFilterExtension
  {
    /// <summary>
    /// Adjust the input audio volume.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <param name="volume">Set audio volume expression. Output values are clipped to the maximum value.</param>
    /// <returns></returns>
    public static VolumeFilter Volume(this IAudioMap audioMap, Action<Expression> volume)
    {
      return new VolumeFilter(volume, audioMap ?? throw new ArgumentNullException(nameof(audioMap)));
    }

    /// <summary>
    /// Adjust the input audio volume.
    /// </summary>
    /// <param name="audioMap"></param>
    /// <param name="volume">Set audio volume expression. Output values are clipped to the maximum value.</param>
    /// <returns></returns>
    public static VolumeFilter Volume(this IAudioMap audioMap, string volume)
    {
      return new VolumeFilter(volume.Expression(), audioMap ?? throw new ArgumentNullException(nameof(audioMap)));
    }
  }

  #region Enum
  /// <summary>
  /// Set when the volume expression is evaluated.
  /// </summary>
  public enum VolumeEval
  {
    /// <summary>
    /// only evaluate expression once during the filter initialization, or when the ‘volume’ command is sent
    /// </summary>
    Once,

    /// <summary>
    /// evaluate expression for each incoming frame
    /// </summary>
    Frame
  }
  public enum VolumeNumberPrecision
  {
    /// <summary>
    /// 8-bit fixed-point; this limits input sample format to U8, S16, and S32.
    /// </summary>
    Fixed,

    /// <summary>
    /// 32-bit floating-point; this limits input sample format to FLT. (default)
    /// </summary>
    Float,

    /// <summary>
    /// 64-bit floating-point; this limits input sample format to DBL.
    /// </summary>
    Double
  }
  public enum VolumeReplayGain
  {
    /// <summary>
    /// Remove ReplayGain side data, ignoring its contents (the default).
    /// </summary>
    drop,

    /// <summary>
    /// Ignore ReplayGain side data, but leave it in the frame.
    /// </summary>
    ignore,

    /// <summary>
    /// Prefer the track gain, if present.
    /// </summary>
    track,

    /// <summary>
    /// Prefer the album gain, if present.
    /// </summary>
    album
  }
  #endregion
}
