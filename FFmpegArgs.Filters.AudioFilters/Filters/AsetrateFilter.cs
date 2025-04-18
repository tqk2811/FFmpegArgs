/*
asetrate AVOptions:
  sample_rate       <int>        ..F.A...... set the sample rate (from 1 to INT_MAX) (default 44100)
  r                 <int>        ..F.A...... set the sample rate (from 1 to INT_MAX) (default 44100)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... asetrate          A->A       Change the sample rate without altering the data.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#asetrate
    /// </summary>
    public class AsetrateFilter : AudioToAudioFilter
    {
        internal AsetrateFilter(AudioMap audioMap) : base("asetrate", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the output sample rate. Default is 44100 Hz.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public AsetrateFilter SampleRate(int r)
            => this.SetOptionRange("r", r, 0, INT_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsetrateFilterExtensions
    {
        /// <summary>
        /// Set the sample rate without altering the PCM data. This will result in a change of speed and pitch.
        /// </summary>
        public static AsetrateFilter AsetrateFilter(this AudioMap audioMap)
          => new AsetrateFilter(audioMap);
    }
}
