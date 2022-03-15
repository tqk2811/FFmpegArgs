/*
asetnsamples AVOptions:
  nb_out_samples    <int>        ..F.A...... set the number of per-frame output samples (from 1 to INT_MAX) (default 1024)
  n                 <int>        ..F.A...... set the number of per-frame output samples (from 1 to INT_MAX) (default 1024)
  pad               <boolean>    ..F.A...... pad last frame with zeros (default true)
  p                 <boolean>    ..F.A...... pad last frame with zeros (default true)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  ... asetnsamples      A->A       Set the number of samples for each output audio frames.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#asetnsamples
    /// </summary>
    public class AsetnsamplesFilter : AudioToAudioFilter
    {
        internal AsetnsamplesFilter(AudioMap audioMap) : base("asetnsamples", audioMap)
        {
            AddMapOut();
        }
        
        /// <summary>
        /// set the number of per-frame output samples (from 1 to INT_MAX) (default 1024)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public AsetnsamplesFilter NbOutSamples(int n)
            => this.SetOptionRange("n", n, 1, INT_MAX);

        /// <summary>
        /// pad last frame with zeros (default true)
        /// </summary>
        /// <param name="pad"></param>
        /// <returns></returns>
        public AsetnsamplesFilter Pad(bool pad)
            => this.SetOption("p", pad.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsetnsamplesFilterExtensions
    {
        /// <summary>
        /// Set the number of samples per each output audio frame.<br>
        /// </br>The last output packet may contain a different number of samples, as the filter will flush all the remaining samples when the input audio signals its end.
        /// </summary>
        public static AsetnsamplesFilter AsetnsamplesFilter(this AudioMap audioMap)
          => new AsetnsamplesFilter(audioMap);
    }
}
