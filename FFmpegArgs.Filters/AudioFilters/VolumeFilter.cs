using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// T.C volume            A->A       Change input volume. <br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#volume
    /// </summary>
    public class VolumeFilter : AudioToAudioFilter, ITimelineSupport, ICommandSupport
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
        internal VolumeFilter(AudioMap audioMap) : base("volume", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set audio volume expression.<br></br>
        /// Output values are clipped to the maximum value.<br></br>
        /// The output audio volume is given by the relation:<br></br>
        /// <b>output_volume = volume * input_volume</b><br></br>
        /// The default value for volume is "1.0".
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        public VolumeFilter Volume(string volume)
            => this.Volume(volume.Expression());
        /// <summary>
        /// Set audio volume expression.<br></br>
        /// Output values are clipped to the maximum value.<br></br>
        /// The output audio volume is given by the relation:<br></br>
        /// <b>output_volume = volume * input_volume</b><br></br>
        /// The default value for volume is "1.0".
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        public VolumeFilter Volume(Action<Expression> volume)
            => this.SetOption("volume", volume.Run(expression));
        /// <summary>
        /// Set audio volume expression.<br></br>
        /// Output values are clipped to the maximum value.<br></br>
        /// The output audio volume is given by the relation:<br></br>
        /// <b>output_volume = volume * input_volume</b><br></br>
        /// The default value for volume is "1.0".
        /// </summary>
        /// <param name="volume"></param>
        /// <returns></returns>
        public VolumeFilter Volume(float volume)
            => this.SetOptionRange("volume", volume, 0, float.MaxValue);

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
        /// Default value for replaygain_preamp is 0.0.<br>
        /// </br>Apply replaygain pre-amplification (from -15 to 15) (default 0)
        /// </summary>
        /// <param name="replaygain_preamp"></param>
        /// <returns></returns>
        public VolumeFilter ReplaygainPreamp(double replaygain_preamp)
            => this.SetOptionRange("replaygain_preamp", replaygain_preamp, -15, 15);

        /// <summary>
        /// Prevent clipping by limiting the gain applied.<br></Br>
        /// Default value for replaygain_noclip is 1.
        /// </summary>
        /// <param name="replaygain_noclip"></param>
        /// <returns></returns>
        public VolumeFilter ReplaygainNoclip(bool replaygain_noclip)
            => this.SetOption("replaygain_noclip", replaygain_noclip.ToFFmpegFlag());
    }

    public static class VolumeFilterExtension
    {
        /// <summary>
        /// Adjust the input audio volume.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static VolumeFilter Volume(this AudioMap audioMap)
            => new VolumeFilter(audioMap);

        /// <summary>
        /// Adjust the input audio volume.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="volume">Set audio volume expression. Output values are clipped to the maximum value.</param>
        /// <returns></returns>
        public static VolumeFilter Volume(this AudioMap audioMap, Action<Expression> volume)
            => new VolumeFilter(audioMap).Volume(volume);

        /// <summary>
        /// Adjust the input audio volume.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="volume">Set audio volume expression. Output values are clipped to the maximum value.</param>
        /// <returns></returns>
        public static VolumeFilter Volume(this AudioMap audioMap, string volume)
            => new VolumeFilter(audioMap).Volume(volume);


        /// <summary>
        /// Change input volume.
        /// </summary>
        public static VolumeFilter VolumeFilterGen(this AudioMap audioMap, VolumeFilterConfig config)
        {
            var result = new VolumeFilter(audioMap);
            if (!string.IsNullOrWhiteSpace(config?.Volume)) result.Volume(config.Volume);
            if (config?.Precision != null) result.Precision(config.Precision.Value);
            if (config?.Eval != null) result.Eval(config.Eval.Value);
            if (config?.Replaygain != null) result.ReplayGain(config.Replaygain.Value);
            if (config?.ReplaygainPreamp != null) result.ReplaygainPreamp(config.ReplaygainPreamp.Value);
            if (config?.ReplaygainNoclip != null) result.ReplaygainNoclip(config.ReplaygainNoclip.Value);
            if (!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
            return result;
        }
    }

    public class VolumeFilterConfig : ITimelineSupportConfig
    {
        /// <summary>
        ///  set volume adjustment expression (default "1.0")
        /// </summary>
        public string Volume { get; set; }
        /// <summary>
        ///  select mathematical precision (from 0 to 2) (default float)
        /// </summary>
        public VolumeNumberPrecision? Precision { get; set; }
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default once)
        /// </summary>
        public VolumeEval? Eval { get; set; }
        /// <summary>
        ///  Apply replaygain side data when present (from 0 to 3) (default drop)
        /// </summary>
        public VolumeReplayGain? Replaygain { get; set; }
        /// <summary>
        ///  Apply replaygain pre-amplification (from -15 to 15) (default 0)
        /// </summary>
        public double? ReplaygainPreamp { get; set; }
        /// <summary>
        ///  Apply replaygain clipping prevention (default true)
        /// </summary>
        public bool? ReplaygainNoclip { get; set; }
        public string TimelineSupport { get; set; }
    }


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
}
