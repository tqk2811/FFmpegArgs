/*
aecho AVOptions:
  in_gain           <float>      ..F.A...... set signal input gain (from 0 to 1) (default 0.6)
  out_gain          <float>      ..F.A...... set signal output gain (from 0 to 1) (default 0.3)
  delays            <string>     ..F.A...... set list of signal delays (default "1000")
  decays            <string>     ..F.A...... set list of signal decays (default "0.5")
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... aecho             A->A       Add echoing to the audio.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#aecho"/>
    /// </summary>
    public class AechoFilter : AudioToAudioFilter
    {
        internal AechoFilter(AudioMap audioMap) : base("aecho", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set input gain of reflected signal. (from 0 to 1) (default 0.6)
        /// </summary>
        /// <param name="in_gain"></param>
        /// <returns></returns>
        public AechoFilter InGain(float in_gain)
            => this.SetOptionRange("in_gain", in_gain, 0, 1);

        /// <summary>
        /// Set output gain of reflected signal. (from 0 to 1) (default 0.3)
        /// </summary>
        /// <param name="out_gain"></param>
        /// <returns></returns>
        public AechoFilter OutGain(float out_gain)
            => this.SetOptionRange("out_gain", out_gain, 0, 1);

        /// <summary>
        /// Set list of time intervals in milliseconds between original signal and reflections separated by ’|’.<br>
        /// </br> Allowed range for each delay is (0 - 90000.0]. Default is 1000.
        /// </summary>
        /// <param name="delays"></param>
        /// <returns></returns>
        public AechoFilter Delays(params double[] delays)
        {
            if (delays == null || delays.Length == 0)
                throw new ArgumentNullException(nameof(delays));
            if (delays.Any(x => x <= 0 || x > 90000))
                throw new ArgumentException("Delay item must be in range (0 - 90000.0]");

            return this.SetOption("delays", string.Join("|", delays));
        }

        /// <summary>
        /// Set list of loudness of reflected signals separated by ’|’.<br>
        /// </br> Allowed range for each decay is (0 - 1.0]. Default is 0.5.
        /// </summary>
        /// <param name="decays"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public AechoFilter Decays(params double[] decays)
        {
            if (decays == null || decays.Length == 0)
                throw new ArgumentNullException(nameof(decays));
            if (decays.Any(x => x <= 0 || x > 1))
                throw new ArgumentException("Decay item must be in range (0 - 1]");

            return this.SetOption("decays", string.Join("|", decays));
        }

    }
    /// <summary>
    /// 
    /// </summary>
    public static class AechoFilterExtensions
    {
        /// <summary>
        /// Apply echoing to the input audio.<br>
        /// </br>Echoes are reflected sound and can occur naturally amongst mountains(and sometimes large buildings) when talking or shouting; digital echo effects emulate this behaviour and are often used to help fill out the sound of a single instrument or vocal.The time difference between the original signal and the reflection is the delay, and the loudness of the reflected signal is the decay. Multiple echoes can have different delays and decays.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#aecho"/>
        /// </summary>
        public static AechoFilter AechoFilter(this AudioMap audioMap)
          => new AechoFilter(audioMap);
    }
}
