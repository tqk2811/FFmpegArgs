/*
sine AVOptions:
  frequency         <double>     ..F.A...... set the sine frequency (from 0 to DBL_MAX) (default 440)
  f                 <double>     ..F.A...... set the sine frequency (from 0 to DBL_MAX) (default 440)
  beep_factor       <double>     ..F.A...... set the beep frequency factor (from 0 to DBL_MAX) (default 0)
  b                 <double>     ..F.A...... set the beep frequency factor (from 0 to DBL_MAX) (default 0)
  sample_rate       <int>        ..F.A...... set the sample rate (from 1 to INT_MAX) (default 44100)
  r                 <int>        ..F.A...... set the sample rate (from 1 to INT_MAX) (default 44100)
  duration          <duration>   ..F.A...... set the audio duration (default 0)
  d                 <duration>   ..F.A...... set the audio duration (default 0)
  samples_per_frame <string>     ..F.A...... set the number of samples per frame (default "1024")
 */
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
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal SineFilter(IAudioFilterGraph filterGraph) : base("sine", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the carrier frequency. Default is 440 Hz. (from 0 to DBL_MAX) (default 440)
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public SineFilter Frequency(double f)
          => this.SetOptionRange("f", f, 0, DBL_MAX);
        /// <summary>
        /// Enable a periodic beep every second with frequency beep_factor times the carrier frequency. Default is 0, meaning the beep is disabled.
        /// <br></br>(from 0 to DBL_MAX) (default 0)
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public SineFilter BeepFactor(double b)
          => this.SetOptionRange("b", b, 0, DBL_MAX);
        /// <summary>
        /// Specify the sample rate, (from 1 to INT_MAX) (default 44100)
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public SineFilter SampleRate(int r)
          => this.SetOptionRange("r", r, 1, INT_MAX);
        /// <summary>
        /// Specify the duration of the generated audio stream. (default 0)
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public SineFilter Duration(TimeSpan d)
          => this.SetOptionRange("d", d, TimeSpan.MinValue, TimeSpan.MaxValue);
        /// <summary>
        /// Set the number of samples per output frame.<br>
        /// </br>Default: 1024
        /// </summary>
        /// <param name="samples_per_frame">Default is 1024.</param>
        /// <returns></returns>
        public SineFilter SamplesPerFrame(ExpressionValue samples_per_frame)
          => this.SetOption("samples_per_frame", expression.Check(samples_per_frame));
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SineFilterExtensions
    {
        /// <summary>
        /// Generate an audio signal made of a sine wave with amplitude 1/8.<br></br>
        /// The audio signal is bit-exact.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static SineFilter SineFilter(this IAudioFilterGraph filterGraph)
          => new SineFilter(filterGraph);
    }
}
