/*
agate AVOptions:
  level_in          <double>     ..F.A....T. set input level (from 0.015625 to 64) (default 1)
  mode              <int>        ..F.A....T. set mode (from 0 to 1) (default downward)
     downward        0            ..F.A....T.
     upward          1            ..F.A....T.
  range             <double>     ..F.A....T. set max gain reduction (from 0 to 1) (default 0.06125)
  threshold         <double>     ..F.A....T. set threshold (from 0 to 1) (default 0.125)
  ratio             <double>     ..F.A....T. set ratio (from 1 to 9000) (default 2)
  attack            <double>     ..F.A....T. set attack (from 0.01 to 9000) (default 20)
  release           <double>     ..F.A....T. set release (from 0.01 to 9000) (default 250)
  makeup            <double>     ..F.A....T. set makeup gain (from 1 to 64) (default 1)
  knee              <double>     ..F.A....T. set knee (from 1 to 8) (default 2.82843)
  detection         <int>        ..F.A....T. set detection (from 0 to 1) (default rms)
     peak            0            ..F.A....T.
     rms             1            ..F.A....T.
  link              <int>        ..F.A....T. set link (from 0 to 1) (default average)
     average         0            ..F.A....T.
     maximum         1            ..F.A....T.
  level_sc          <double>     ..F.A....T. set sidechain gain (from 0.015625 to 64) (default 1)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  T.C agate             A->A       Audio gate.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#agate
    /// </summary>
    public class AgateFilter : AudioToAudioFilter, ITimelineSupport, ICommandSupport
    {
        internal AgateFilter(AudioMap audioMap) : base("agate", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set input level before filtering. Default is 1. Allowed range is from 0.015625 to 64.
        /// </summary>
        /// <param name="level_in"></param>
        /// <returns></returns>
        public AgateFilter LevelIn(double level_in)
            => this.SetOptionRange("level_in", level_in, 0.015625, 64);
        /// <summary>
        /// Set the mode of operation. Can be upward or downward. Default is downward. If set to upward mode, higher parts of signal will be amplified, expanding dynamic range in upward direction. Otherwise, in case of downward lower parts of signal will be reduced.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public AgateFilter Mode(AgateMode mode)
            => this.SetOption("mode", mode);
        /// <summary>
        /// Set the level of gain reduction when the signal is below the threshold. Default is 0.06125. Allowed range is from 0 to 1. Setting this to 0 disables reduction and then filter behaves like expander.<br>
        /// </br>(from 0 to 1) (default 0.06125)
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public AgateFilter Range(double range)
            => this.SetOptionRange("range", range, 0, 1);
        /// <summary>
        /// If a signal rises above this level the gain reduction is released. Default is 0.125. Allowed range is from 0 to 1.<br>
        /// </br>(from 0 to 1) (default 0.125)
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public AgateFilter Threshold(double threshold)
            => this.SetOptionRange("threshold", threshold, 0, 1);
        /// <summary>
        /// Set a ratio by which the signal is reduced. Default is 2. Allowed range is from 1 to 9000.<br>
        /// </br>(from 1 to 9000) (default 2)
        /// </summary>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public AgateFilter Ratio(double ratio)
            => this.SetOptionRange("ratio", ratio, 1, 9000);
        /// <summary>
        /// Amount of milliseconds the signal has to rise above the threshold before gain reduction stops. Default is 20 milliseconds. Allowed range is from 0.01 to 9000.<br>
        /// </br>(from 0.01 to 9000) (default 20)
        /// </summary>
        /// <param name="attack"></param>
        /// <returns></returns>
        public AgateFilter Attack(double attack)
            => this.SetOptionRange("attack", attack, 0.01, 9000);
        /// <summary>
        /// Amount of milliseconds the signal has to fall below the threshold before the reduction is increased again. Default is 250 milliseconds. Allowed range is from 0.01 to 9000.<br>
        /// </br>(from 0.01 to 9000) (default 250)
        /// </summary>
        /// <param name="release"></param>
        /// <returns></returns>
        public AgateFilter Release(double release)
            => this.SetOptionRange("release", release, 0.01, 9000);
        /// <summary>
        /// Set amount of amplification of signal after processing. Default is 1. Allowed range is from 1 to 64.<br>
        /// </br>(from 1 to 64) (default 1)
        /// </summary>
        /// <param name="makeup"></param>
        /// <returns></returns>
        public AgateFilter MakeUp(double makeup)
            => this.SetOptionRange("makeup", makeup, 1, 64);
        /// <summary>
        /// Curve the sharp knee around the threshold to enter gain reduction more softly. Default is 2.828427125. Allowed range is from 1 to 8.<br>
        /// </br>(from 1 to 8) (default 2.82843)
        /// </summary>
        /// <param name="knee"></param>
        /// <returns></returns>
        public AgateFilter Knee(double knee)
            => this.SetOptionRange("knee", knee, 1, 8);
        /// <summary>
        /// Choose if exact signal should be taken for detection or an RMS like one. Default is rms. Can be peak or rms.<br>
        /// </br>
        /// </summary>
        /// <param name="detection"></param>
        /// <returns></returns>
        public AgateFilter Detection(AgateDetection detection)
            => this.SetOption("detection", detection);
        /// <summary>
        /// Choose if the average level between all channels or the louder channel affects the reduction. Default is average. Can be average or maximum.
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public AgateFilter Link(AgateLink link)
            => this.SetOption("link", link);
        /// <summary>
        /// set sidechain gain (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <param name="level_sc"></param>
        /// <returns></returns>
        public AgateFilter LevelSc(double level_sc)
            => this.SetOptionRange("level_sc", level_sc, 0.015625, 64);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AgateFilterExtensions
    {
        /// <summary>
        /// A gate is mainly used to reduce lower parts of a signal. This kind of signal processing reduces disturbing noise between useful signals.<br>
        /// </br>Gating is done by detecting the volume below a chosen level threshold and dividing it by the factor set with ratio.The bottom of the noise floor is set via range.Because an exact manipulation of the signal would cause distortion of the waveform the reduction can be levelled over time.This is done by setting attack and release.<br>
        /// </br>attack determines how long the signal has to fall below the threshold before any reduction will occur and release sets the time the signal has to rise above the threshold to reduce the reduction again. Shorter signals than the chosen attack time will be left untouched.
        /// </summary>
        public static AgateFilter AgateFilter(this AudioMap audioMap)
          => new AgateFilter(audioMap);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AgateMode
    {
        /// <summary>
        /// 
        /// </summary>
        downward,
        /// <summary>
        /// 
        /// </summary>
        upward
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AgateDetection
    {
        /// <summary>
        /// 
        /// </summary>
        peak,
        /// <summary>
        /// 
        /// </summary>
        rms
    }
    /// <summary>
    /// 
    /// </summary>
    public enum AgateLink
    {
        /// <summary>
        /// 
        /// </summary>
        average,
        /// <summary>
        /// 
        /// </summary>
        maximum
    }
}
