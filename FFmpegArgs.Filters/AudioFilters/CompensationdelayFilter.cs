/*
compensationdelay AVOptions:
  mm                <int>        ..F.A...... set mm distance (from 0 to 10) (default 0)
  cm                <int>        ..F.A...... set cm distance (from 0 to 100) (default 0)
  m                 <int>        ..F.A...... set meter distance (from 0 to 100) (default 0)
  dry               <double>     ..F.A...... set dry amount (from 0 to 1) (default 0)
  wet               <double>     ..F.A...... set wet amount (from 0 to 1) (default 1)
  temp              <int>        ..F.A...... set temperature °C (from -50 to 50) (default 20)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... compensationdelay A->A       Audio Compensation Delay Line.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#compensationdelay
    /// </summary>
    public class CompensationdelayFilter : AudioToAudioFilter
    {
        internal CompensationdelayFilter(AudioMap audioMap) : base("compensationdelay", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set millimeters distance. This is compensation distance for fine tuning. (from 0 to 10) (default 0)
        /// </summary>
        /// <param name="mm"></param>
        /// <returns></returns>
        public CompensationdelayFilter Mm(int mm)
            => this.SetOptionRange("mm", mm, 0, 10);
        /// <summary>
        /// Set cm distance. This is compensation distance for tightening distance setup. (from 0 to 100) (default 0)
        /// </summary>
        /// <param name="cm"></param>
        /// <returns></returns>
        public CompensationdelayFilter Cm(int cm)
            => this.SetOptionRange("cm", cm, 0, 100);
        /// <summary>
        /// Set meter distance. This is compensation distance for hard distance setup. (from 0 to 100) (default 0)
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public CompensationdelayFilter M(int m)
            => this.SetOptionRange("m", m, 0, 100);
        /// <summary>
        /// Set dry amount. Amount of unprocessed (dry) signal. (from 0 to 1) (default 0)
        /// </summary>
        /// <param name="dry"></param>
        /// <returns></returns>
        public CompensationdelayFilter Dry(double dry)
            => this.SetOptionRange("dry", dry, 0, 1);
        /// <summary>
        /// Set wet amount. Amount of processed (wet) signal. (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="wet"></param>
        /// <returns></returns>
        public CompensationdelayFilter Wet(double wet)
            => this.SetOptionRange("wet", wet, 0, 1);
        /// <summary>
        /// Set temperature °C. This is the temperature of the environment. (from -50 to 50) (default 20)
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public CompensationdelayFilter Temp(int temp)
            => this.SetOptionRange("temp", temp, -50, 50);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class CompensationdelayFilterExtensions
    {
        /// <summary>
        /// Compensation Delay Line is a metric based delay to compensate differing positions of microphones or speakers.<br>
        /// </br>For example, you have recorded guitar with two microphones placed in different locations.Because the front of sound wave has fixed speed in normal conditions, the phasing of microphones can vary and depends on their location and interposition.The best sound mix can be achieved when these microphones are in phase(synchronized).Note that a distance of ~30 cm between microphones makes one microphone capture the signal in antiphase to the other microphone.That makes the final mix sound moody.This filter helps to solve phasing problems by adding different delays to each microphone track and make them synchronized.<br>
        /// </br>The best result can be reached when you take one track as base and synchronize other tracks one by one with it.Remember that synchronization / delay tolerance depends on sample rate, too.Higher sample rates will give more tolerance.
        /// </summary>
        public static CompensationdelayFilter CompensationdelayFilter(this AudioMap audioMap)
          => new CompensationdelayFilter(audioMap);
    }
}
