/*
aphaser AVOptions:
  in_gain           <double>     ..F.A...... set input gain (from 0 to 1) (default 0.4)
  out_gain          <double>     ..F.A...... set output gain (from 0 to 1e+09) (default 0.74)
  delay             <double>     ..F.A...... set delay in milliseconds (from 0 to 5) (default 3)
  decay             <double>     ..F.A...... set decay (from 0 to 0.99) (default 0.4)
  speed             <double>     ..F.A...... set modulation speed (from 0.1 to 2) (default 0.5)
  type              <int>        ..F.A...... set modulation type (from 0 to 1) (default triangular)
     triangular      1            ..F.A......
     t               1            ..F.A......
     sinusoidal      0            ..F.A......
     s               0            ..F.A......
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... aphaser           A->A       Add a phasing effect to the audio.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#aphaser"/>
    /// </summary>
    public class AphaserFilter : AudioToAudioFilter
    {
        internal AphaserFilter(AudioMap audioMap) : base("aphaser", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// set input gain (from 0 to 1) (default 0.4)
        /// </summary>
        /// <param name="in_gain"></param>
        /// <returns></returns>
        public AphaserFilter InGain(double in_gain)
            => this.SetOptionRange("in_gain", in_gain, 0, 1);

        /// <summary>
        /// set output gain (from 0 to 1e+09) (default 0.74)
        /// </summary>
        /// <param name="out_gain"></param>
        /// <returns></returns>
        public AphaserFilter OutGain(double out_gain)
           => this.SetOptionRange("out_gain", out_gain, 0, 1e+09);

        /// <summary>
        /// set delay in milliseconds (from 0 to 5) (default 3)
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public AphaserFilter Delay(double delay)
           => this.SetOptionRange("delay", delay, 0, 5);

        /// <summary>
        /// set decay (from 0 to 0.99) (default 0.4)
        /// </summary>
        /// <param name="decay"></param>
        /// <returns></returns>
        public AphaserFilter Decay(double decay)
           => this.SetOptionRange("decay", decay, 0, 0.99);

        /// <summary>
        /// set modulation speed (from 0.1 to 2) (default 0.5)
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public AphaserFilter Speed(double speed)
           => this.SetOptionRange("speed", speed, 0.1, 2);

        /// <summary>
        /// set modulation type (from 0 to 1) (default triangular)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public AphaserFilter Type(AphaserType type)
            => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AphaserFilterExtensions
    {
        /// <summary>
        /// Add a phasing effect to the input audio.<br>
        /// </br>A phaser filter creates series of peaks and troughs in the frequency spectrum.The position of the peaks and troughs are modulated so that they vary over time, creating a sweeping effect.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#aphaser"/>
        /// </summary>
        public static AphaserFilter AphaserFilter(this AudioMap audioMap)
          => new AphaserFilter(audioMap);
    }

    /// <summary>
    /// set modulation type (from 0 to 1) (default triangular)
    /// </summary>
    public enum AphaserType
    {
        /// <summary>
        /// 
        /// </summary>
        [Name("s")]
        Sinusoidal = 0,
        /// <summary>
        /// 
        /// </summary>
        [Name("t")]
        Triangular = 1
    }
}
