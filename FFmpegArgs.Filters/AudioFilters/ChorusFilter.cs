/*
chorus AVOptions:
  in_gain           <float>      ..F.A...... set input gain (from 0 to 1) (default 0.4)
  out_gain          <float>      ..F.A...... set output gain (from 0 to 1) (default 0.4)
  delays            <string>     ..F.A...... set delays
  decays            <string>     ..F.A...... set decays
  speeds            <string>     ..F.A...... set speeds
  depths            <string>     ..F.A...... set depths
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... chorus            A->A       Add a chorus effect to the audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#chorus
    /// </summary>
    public class ChorusFilter : AudioToAudioFilter
    {
        internal ChorusFilter(AudioMap audioMap) : base("chorus", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set input gain. Default is 0.4.
        /// </summary>
        /// <param name="in_gain"></param>
        /// <returns></returns>
        public ChorusFilter InGain(float in_gain)
            => this.SetOptionRange("in_gain", in_gain, 0, 1);

        /// <summary>
        /// Set output  gain. Default is 0.4.
        /// </summary>
        /// <param name="out_gain"></param>
        /// <returns></returns>
        public ChorusFilter OutGain(float out_gain)
            => this.SetOptionRange("out_gain", out_gain, 0, 1);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="chorus"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ChorusFilter Chorus(params ChorusFilterOption[] chorus)
        {
            if (chorus == null || chorus.Length == 0) throw new ArgumentNullException(nameof(chorus));
            this.SetOption("delays", string.Join("|", chorus.Select(x => x.Delay)));
            this.SetOption("decays", string.Join("|", chorus.Select(x => x.Decay)));
            this.SetOption("speeds", string.Join("|", chorus.Select(x => x.Speed)));
            this.SetOption("depths", string.Join("|", chorus.Select(x => x.Depth)));
            return this;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class ChorusFilterExtensions
    {
        /// <summary>
        /// Add a chorus effect to the audio.<br>
        /// </br>Can make a single vocal sound like a chorus, but can also be applied to instrumentation.<br>
        /// </br>Chorus resembles an echo effect with a short delay, but whereas with echo the delay is constant, with chorus, it is varied using using sinusoidal or triangular modulation.The modulation depth defines the range the modulated delay is played before or after the delay.Hence the delayed sound will sound slower or faster, that is the delayed sound tuned around the original one, like in a chorus where some vocals are slightly off key.
        /// </summary>
        public static ChorusFilter ChorusFilter(this AudioMap audioMap)
          => new ChorusFilter(audioMap);
    }

    /// <summary>
    /// 
    /// </summary>
    public class ChorusFilterOption
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public float Delay { get; set; }
        public float Decay { get; set; }
        public float Speed { get; set; }
        public float Depth { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
