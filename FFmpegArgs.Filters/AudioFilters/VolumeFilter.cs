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
      _mapsOut.Add(new AudioMap(this.FilterGraph, $"f_{FilterIndex}"));
      this.SetOption("volume", volume.Run(expression));
    }

    public VolumeFilter Precision(VolumeNumberPrecision precision)
      => this.SetOption("precision", precision.ToString().ToLower());

    public VolumeFilter ReplayGain(VolumeReplayGain replayGain)
      => this.SetOption("replaygain", replayGain.ToString().ToLower());

    public VolumeFilter Eval(VolumeEval eval)
       => this.SetOption("eval", eval.ToString().ToLower());
  }

  public static class VolumeFilterExtension
  {
    public static VolumeFilter Volume(this IAudioMap audioMap, Action<Expression> volume)
    {
      return new VolumeFilter(volume, audioMap ?? throw new ArgumentNullException(nameof(audioMap)));
    }
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
    Fixed,
    Float,
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
