using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.AudioSources
{
    /// <summary>
    ///  ... sine              |->A       Generate sine wave audio signal.<br></br>
    ///  https://ffmpeg.org/ffmpeg-filters.html#sine
    /// </summary>
    public class SineFilter : SourceAudioFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "n", "pts", "t", "TB"
        };
        readonly Expression expression = new Expression(_variables);
        internal SineFilter(FilterGraph filterGraph) : base("sine", filterGraph)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the carrier frequency. Default is 440 Hz.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public SineFilter Frequency(int f)
          => this.SetOptionRange("f", f, 0, int.MaxValue);

        /// <summary>
        /// Enable a periodic beep every second with frequency beep_factor times the carrier frequency. Default is 0, meaning the beep is disabled.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public SineFilter BeepFactor(bool flag)
          => this.SetOption("b", flag.ToFFmpegFlag());

        /// <summary>
        /// Specify the sample rate, default is 44100.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public SineFilter SampleRate(int r)
          => this.SetOptionRange("r", r, 0, int.MaxValue);

        /// <summary>
        /// Specify the duration of the generated audio stream.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public SineFilter Duration(TimeSpan d)
          => this.SetOptionRange("d", d, TimeSpan.Zero, TimeSpan.MaxValue);

        /// <summary>
        /// Set the number of samples per output frame.
        /// </summary>
        /// <param name="samples_per_frame">Default is 1024.</param>
        /// <returns></returns>
        public SineFilter SamplesPerFrame(string samples_per_frame)
          => this.SetOption("samples_per_frame", samples_per_frame.Expression().Run(expression));

        /// <summary>
        /// Set the number of samples per output frame.
        /// </summary>
        /// <param name="samples_per_frame">Default is 1024.</param>
        /// <returns></returns>
        public SineFilter SamplesPerFrame(Action<Expression> samples_per_frame)
          => this.SetOption("samples_per_frame", samples_per_frame.Run(expression));
    }

    public static class SineFilterExtensions
    {
        /// <summary>
        /// Generate an audio signal made of a sine wave with amplitude 1/8.<br></br>
        /// The audio signal is bit-exact.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static SineFilter SineFilter(this FilterGraph filterGraph)
          => new SineFilter(filterGraph);
    }
}
