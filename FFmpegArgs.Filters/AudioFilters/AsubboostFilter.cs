/*
asubboost AVOptions:
  dry               <double>     ..F.A....T. set dry gain (from 0 to 1) (default 0.7)
  wet               <double>     ..F.A....T. set wet gain (from 0 to 1) (default 0.7)
  decay             <double>     ..F.A....T. set decay (from 0 to 1) (default 0.7)
  feedback          <double>     ..F.A....T. set feedback (from 0 to 1) (default 0.9)
  cutoff            <double>     ..F.A....T. set cutoff (from 50 to 900) (default 100)
  slope             <double>     ..F.A....T. set slope (from 0.0001 to 1) (default 0.5)
  delay             <double>     ..F.A....T. set delay (from 1 to 100) (default 20)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC asubboost         A->A       Boost subwoofer frequencies.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#asubboost"/>
    /// </summary>
    public class AsubboostFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AsubboostFilter(AudioMap audioMap) : base("asubboost", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set dry gain, how much of original signal is kept. Allowed range is from 0 to 1. Default value is 0.7.
        /// </summary>
        /// <param name="dry"></param>
        /// <returns></returns>
        public AsubboostFilter Dry(double dry)
            => this.SetOptionRange("dry", dry, 0, 1);

        /// <summary>
        /// Set wet gain, how much of filtered signal is kept. Allowed range is from 0 to 1. Default value is 0.7.
        /// </summary>
        /// <param name="wet"></param>
        /// <returns></returns>
        public AsubboostFilter Wet(double wet)
            => this.SetOptionRange("wet", wet, 0, 1);

        /// <summary>
        /// Set delay line decay gain value. Allowed range is from 0 to 1. Default value is 0.7.
        /// </summary>
        /// <param name="decay"></param>
        /// <returns></returns>
        public AsubboostFilter Decay(double decay)
            => this.SetOptionRange("decay", decay, 0, 1);

        /// <summary>
        /// Set delay line feedback gain value. Allowed range is from 0 to 1. Default value is 0.9.
        /// </summary>
        /// <param name="feedback"></param>
        /// <returns></returns>
        public AsubboostFilter Feedback(double feedback)
            => this.SetOptionRange("feedback", feedback, 0, 1);

        /// <summary>
        /// Set cutoff frequency in Hertz. Allowed range is 50 to 900. Default value is 100.
        /// </summary>
        /// <param name="cutoff"></param>
        /// <returns></returns>
        public AsubboostFilter Cutoff(double cutoff)
            => this.SetOptionRange("cutoff", cutoff, 50, 900);

        /// <summary>
        /// Set slope amount for cutoff frequency. Allowed range is 0.0001 to 1. Default value is 0.5.
        /// </summary>
        /// <param name="slope"></param>
        /// <returns></returns>
        public AsubboostFilter Slope(double slope)
            => this.SetOptionRange("slope", slope, 0.0001, 1);

        /// <summary>
        /// Set delay. Allowed range is from 1 to 100. Default value is 20.
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public AsubboostFilter Delay(double delay)
            => this.SetOptionRange("delay", delay, 1, 100);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsubboostFilterExtensions
    {
        /// <summary>
        /// Boost subwoofer frequencies.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#asubboost"/>
        /// </summary>
        public static AsubboostFilter AsubboostFilter(this AudioMap audioMap)
          => new AsubboostFilter(audioMap);
    }
}
