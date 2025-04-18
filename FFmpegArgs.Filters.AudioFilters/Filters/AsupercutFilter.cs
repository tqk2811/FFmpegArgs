/*
asupercut AVOptions:
  cutoff            <double>     ..F.A....T. set cutoff frequency (from 20000 to 192000) (default 20000)
  order             <int>        ..F.A....T. set filter order (from 3 to 20) (default 10)
  level             <double>     ..F.A....T. set input level (from 0 to 1) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC asupercut         A->A       Cut super frequencies.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#asupercut
    /// </summary>
    public class AsupercutFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AsupercutFilter(AudioMap audioMap) : base("asupercut", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set cutoff frequency in Hertz. Allowed range is 20000 to 192000. Default value is 20000.
        /// </summary>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public AsupercutFilter Cutoff(double cutoff)
            => this.SetOptionRange("cutoff", cutoff, 20000, 192000);

        /// <summary>
        /// Set filter order. Available values are from 3 to 20. Default value is 10.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public AsupercutFilter Order(int order)
           => this.SetOptionRange("order", order, 3, 20);

        /// <summary>
        /// Set input gain level. Allowed range is from 0 to 1. Default value is 1.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AsupercutFilter Level(double level)
           => this.SetOptionRange("level", level, 0, 1);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsupercutFilterExtensions
    {
        /// <summary>
        /// Cut super frequencies.
        /// </summary>
        public static AsupercutFilter AsupercutFilter(this AudioMap audioMap)
          => new AsupercutFilter(audioMap);
    }
}
