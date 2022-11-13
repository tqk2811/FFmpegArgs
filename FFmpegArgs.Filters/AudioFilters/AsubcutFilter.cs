/*
asubcut AVOptions:
  cutoff            <double>     ..F.A....T. set cutoff frequency (from 2 to 200) (default 20)
  order             <int>        ..F.A....T. set filter order (from 3 to 20) (default 10)
  level             <double>     ..F.A....T. set input level (from 0 to 1) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC asubcut           A->A       Cut subwoofer frequencies.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#asubcut"/>
    /// </summary>
    public class AsubcutFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AsubcutFilter(AudioMap audioMap) : base("asubcut", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set cutoff frequency in Hertz. Allowed range is 2 to 200. Default value is 20.
        /// </summary>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public AsubcutFilter Cutoff(double cutoff)
            => this.SetOptionRange("cutoff", cutoff, 2, 200);

        /// <summary>
        /// Set filter order. Available values are from 3 to 20. Default value is 10.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public AsubcutFilter Order(int order)
           => this.SetOptionRange("order", order, 3, 20);

        /// <summary>
        /// Set input gain level. Allowed range is from 0 to 1. Default value is 1.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AsubcutFilter Level(double level)
           => this.SetOptionRange("level", level, 0, 1);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsubcutFilterExtensions
    {
        /// <summary>
        /// Cut subwoofer frequencies.<br>
        /// </br>This filter allows to set custom, steeper roll off than highpass filter, and thus is able to more attenuate frequency content in stop-band.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#asubcut"/>
        /// </summary>
        public static AsubcutFilter AsubcutFilter(this AudioMap audioMap)
          => new AsubcutFilter(audioMap);
    }
}
