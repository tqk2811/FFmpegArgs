/*
afreqshift AVOptions:
  shift             <double>     ..F.A....T. set frequency shift (from -2.14748e+09 to INT_MAX) (default 0)
  level             <double>     ..F.A....T. set output level (from 0 to 1) (default 1)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC afreqshift        A->A       Apply frequency shifting to input audio.<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#afreqshift"/>
    /// </summary>
    public class AfreqshiftFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AfreqshiftFilter(AudioMap audioMap) : base("afreqshift", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specify frequency shift. (from -2.14748e+09 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="shift"></param>
        /// <returns></returns>
        public AfreqshiftFilter Shift(double shift)
          => this.SetOptionRange("shift", shift, -2.14748e+09, INT_MAX);
        /// <summary>
        /// Set output gain applied to final output. Allowed range is from 0.0 to 1.0. Default value is 1.0.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AfreqshiftFilter Level(double level)
          => this.SetOptionRange("level", level, 0.0, 1.0);
        /// <summary>
        /// Set filter order used for filtering. Allowed range is from 1 to 16. Default value is 8.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        //public AfreqshiftFilter Order(int order)
        //  => this.SetOptionRange("order", order, 1, 16);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AfreqshiftFilterExtensions
    {
        /// <summary>
        /// Apply frequency shift to input audio samples.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#afreqshift"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AfreqshiftFilter AfreqshiftFilter(this AudioMap audioMap)
          => new AfreqshiftFilter(audioMap);
    }
}
