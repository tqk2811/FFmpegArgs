/*
aexciter AVOptions:
  level_in          <double>     ..F.A....T. set level in (from 0 to 64) (default 1)
  level_out         <double>     ..F.A....T. set level out (from 0 to 64) (default 1)
  amount            <double>     ..F.A....T. set amount (from 0 to 64) (default 1)
  drive             <double>     ..F.A....T. set harmonics (from 0.1 to 10) (default 8.5)
  blend             <double>     ..F.A....T. set blend harmonics (from -10 to 10) (default 0)
  freq              <double>     ..F.A....T. set scope (from 2000 to 12000) (default 7500)
  ceil              <double>     ..F.A....T. set ceiling (from 9999 to 20000) (default 9999)
  listen            <boolean>    ..F.A....T. enable listen mode (default false)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  T.C aexciter          A->A       Enhance high frequency part of audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#aexciter
    /// </summary>
    public class AexciterFilter : AudioToAudioFilter, ITimelineSupport, ICommandSupport
    {
        internal AexciterFilter(AudioMap audioMap) : base("aexciter", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set input level prior processing of signal. (from 0 to 64) (default 1)
        /// </summary>
        /// <param name="levelIn"></param>
        /// <returns></returns>
        public AexciterFilter LevelIn(double levelIn)
            => this.SetOptionRange("level_in", levelIn, 0, 64);
        /// <summary>
        /// Set output level after processing of signal. (from 0 to 64) (default 1)
        /// </summary>
        /// <param name="levelOut"></param>
        /// <returns></returns>
        public AexciterFilter LevelOut(double levelOut)
            => this.SetOptionRange("level_out", levelOut, 0, 64);
        /// <summary>
        /// Set the amount of harmonics added to original signal (from 0 to 64) (default 1)
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public AexciterFilter Amount(double amount)
            => this.SetOptionRange("amount", amount, 0, 64);
        /// <summary>
        /// Set the amount of newly created harmonics (from 0.1 to 10) (default 8.5)
        /// </summary>
        /// <param name="drive"></param>
        /// <returns></returns>
        public AexciterFilter Drive(double drive)
            => this.SetOptionRange("drive", drive, 0.1, 10);
        /// <summary>
        /// Set the octave of newly created harmonics (from -10 to 10) (default 0)
        /// </summary>
        /// <param name="blend"></param>
        /// <returns></returns>
        public AexciterFilter Blend(double blend)
            => this.SetOptionRange("blend", blend, -10, 10);
        /// <summary>
        /// Set the lower frequency limit of producing harmonics in Hz (from 2000 to 12000) (default 7500)
        /// </summary>
        /// <param name="freq"></param>
        /// <returns></returns>
        public AexciterFilter Freq(double freq)
            => this.SetOptionRange("freq", freq, 2000, 12000);
        /// <summary>
        /// Set the upper frequency limit of producing harmonics (from 9999 to 20000) (default 9999)
        /// </summary>
        /// <param name="ceil"></param>
        /// <returns></returns>
        public AexciterFilter Ceil(double ceil)
            => this.SetOptionRange("ceil", ceil, 9999, 20000);
        /// <summary>
        /// Mute the original signal and output only added harmonics (default false)
        /// </summary>
        /// <param name="listen"></param>
        /// <returns></returns>
        public AexciterFilter Listen(bool listen)
            => this.SetOption("listen", listen.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AexciterFilterExtensions
    {
        /// <summary>
        /// An exciter is used to produce high sound that is not present in the original signal. This is done by creating harmonic distortions of the signal which are restricted in range and added to the original signal. An Exciter raises the upper end of an audio signal without simply raising the higher frequencies like an equalizer would do to create a more "crisp" or "brilliant" sound.
        /// </summary>
        public static AexciterFilter AexciterFilter(this AudioMap audioMap)
          => new AexciterFilter(audioMap);
    }
}
