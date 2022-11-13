/*
deesser AVOptions:
  i                 <double>     ..F.A...... set intensity (from 0 to 1) (default 0)
  m                 <double>     ..F.A...... set max deessing (from 0 to 1) (default 0.5)
  f                 <double>     ..F.A...... set frequency (from 0 to 1) (default 0.5)
  s                 <int>        ..F.A...... set output mode (from 0 to 2) (default o)
     i               0            ..F.A...... input
     o               1            ..F.A...... output
     e               2            ..F.A...... ess
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// T.. deesser           A->A       Apply de-essing to the audio.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#deesser"/>
    /// </summary>
    public class DeesserFilter : AudioToAudioFilter, ITimelineSupport
    {
        internal DeesserFilter(AudioMap audioMap) : base("deesser", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set intensity for triggering de-essing. Allowed range is from 0 to 1. Default is 0.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public DeesserFilter Intensity(double i)
            => this.SetOptionRange("i", i, 0, 1);

        /// <summary>
        /// Set amount of ducking on treble part of sound. Allowed range is from 0 to 1. Default is 0.5.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public DeesserFilter MaxDeessing(double m)
            => this.SetOptionRange("m", m, 0, 1);

        /// <summary>
        /// How much of original frequency content to keep when de-essing. Allowed range is from 0 to 1. Default is 0.5.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public DeesserFilter Frequency(double f)
            => this.SetOptionRange("f", f, 0, 1);

        /// <summary>
        /// Set output mode (from 0 to 2) (default o)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DeesserFilter OutputMode(DeesserOutputMode s)
            => this.SetOption("s", s.GetEnumAttribute<NameAttribute>().Name);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class DeesserFilterExtensions
    {
        /// <summary>
        /// Apply de-essing to the audio samples.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#deesser"/>
        /// </summary>
        public static DeesserFilter DeesserFilter(this AudioMap audioMap)
          => new DeesserFilter(audioMap);
    }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum DeesserOutputMode
    {
        [Name("i")] Input,
        [Name("o")] Output,
        [Name("e")] Ess,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
