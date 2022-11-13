/*
asuperpass AVOptions:
  centerf           <double>     ..F.A....T. set center frequency (from 2 to 999999) (default 1000)
  order             <int>        ..F.A....T. set filter order (from 4 to 20) (default 4)
  qfactor           <double>     ..F.A....T. set Q-factor (from 0.01 to 100) (default 1)
  level             <double>     ..F.A....T. set input level (from 0 to 2) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC asuperpass        A->A       Apply high order Butterworth band-pass filter.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#asuperpass"/>
    /// </summary>
    public class AsuperpassFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AsuperpassFilter(AudioMap audioMap) : base("asuperpass", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set center frequency in Hertz. Allowed range is 2 to 999999. Default value is 1000.
        /// </summary>
        /// <param name="centerf"></param>
        /// <returns></returns>
        public AsuperpassFilter Centerf(double centerf)
            => this.SetOptionRange("centerf", centerf, 2, 999999);

        /// <summary>
        /// Set filter order. Available values are from 4 to 20. Default value is 4.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public AsuperpassFilter Order(int order)
            => this.SetOptionRange("order", order, 4, 20);

        /// <summary>
        /// Set Q-factor. Allowed range is from 0.01 to 100. Default value is 1.
        /// </summary>
        /// <param name="qfactor"></param>
        /// <returns></returns>
        public AsuperpassFilter Qfactor(double qfactor)
            => this.SetOptionRange("qfactor", qfactor, 0.01, 100);

        /// <summary>
        /// Set input gain level. Allowed range is from 0 to 2. Default value is 1.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AsuperpassFilter Level(double level)
            => this.SetOptionRange("level", level, 0, 2);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsuperpassFilterExtensions
    {
        /// <summary>
        /// Apply high order Butterworth band-pass filter.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#asuperpass"/>
        /// </summary>
        public static AsuperpassFilter AsuperpassFilter(this AudioMap audioMap)
          => new AsuperpassFilter(audioMap);
    }
}
