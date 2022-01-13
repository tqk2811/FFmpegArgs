/*
alimiter AVOptions:
  level_in          <double>     ..F.A...... set input level (from 0.015625 to 64) (default 1)
  level_out         <double>     ..F.A...... set output level (from 0.015625 to 64) (default 1)
  limit             <double>     ..F.A...... set limit (from 0.0625 to 1) (default 1)
  attack            <double>     ..F.A...... set attack (from 0.1 to 80) (default 5)
  release           <double>     ..F.A...... set release (from 1 to 8000) (default 50)
  asc               <boolean>    ..F.A...... enable asc (default false)
  asc_level         <double>     ..F.A...... set asc level (from 0 to 1) (default 0.5)
  level             <boolean>    ..F.A...... auto level (default true)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  ... alimiter          A->A       Audio lookahead limiter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#alimiter
    /// </summary>
    public class AlimiterFilter : AudioToAudioFilter
    {
        internal AlimiterFilter(AudioMap audioMap) : base("alimiter", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set input gain (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <param name="level_in"></param>
        /// <returns></returns>
        public AlimiterFilter LevelIn(double level_in)
            => this.SetOptionRange("level_in", level_in, 0.015625, 64);

        /// <summary>
        /// Set output gain (from 0.015625 to 64) (default 1)
        /// </summary>
        /// <param name="level_out"></param>
        /// <returns></returns>
        public AlimiterFilter LevelOut(double level_out)
            => this.SetOptionRange("level_out", level_out, 0.015625, 64);

        /// <summary>
        /// Don’t let signals above this level pass the limiter.  (from 0.0625 to 1) (default 1)
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public AlimiterFilter Limit(double limit)
            => this.SetOptionRange("limit", limit, 0.0625, 1);

        /// <summary>
        /// The limiter will reach its attenuation level in this amount of time in milliseconds. (from 0.1 to 80) (default 5)
        /// </summary>
        /// <param name="attack"></param>
        /// <returns></returns>
        public AlimiterFilter Attack(double attack)
            => this.SetOptionRange("attack", attack, 0.01, 80);

        /// <summary>
        /// Come back from limiting to attenuation 1.0 in this amount of milliseconds (from 1 to 8000) (default 50)
        /// </summary>
        /// <param name="release"></param>
        /// <returns></returns>
        public AlimiterFilter Release(double release)
            => this.SetOptionRange("release", release, 1, 8000);

        /// <summary>
        /// When gain reduction is always needed ASC takes care of releasing to an average reduction level rather than reaching a reduction of 0 in the release time.
        /// </summary>
        /// <param name="asc"></param>
        /// <returns></returns>
        public AlimiterFilter Asc(bool asc)
            => this.SetOption("asc", asc.ToFFmpegFlag());

        /// <summary>
        /// Select how much the release time is affected by ASC, 0 means nearly no changes in release time while 1 produces higher release times.<br>
        /// </br>(from 0 to 1) (default 0.5)
        /// </summary>
        /// <param name="asc_level"></param>
        /// <returns></returns>
        public AlimiterFilter AscLevel(double asc_level)
           => this.SetOptionRange("asc_level", asc_level, 0, 1);

        /// <summary>
        /// Auto level output signal. Default is enabled. This normalizes audio back to 0dB if enabled.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AlimiterFilter Level(bool level)
            => this.SetOption("level", level.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AlimiterFilterExtensions
    {
        /// <summary>
        /// The limiter prevents an input signal from rising over a desired threshold.<br>
        /// </br> This limiter uses lookahead technology to prevent your signal from distorting.<br>
        /// </br> It means that there is a small delay after the signal is processed. Keep in mind that the delay it produces is the attack time you set.<br>
        /// </br><br>
        /// </br>Depending on picked setting it is recommended to upsample input 2x or 4x times with <see cref="AresampleFilter"/> before applying this filter.
        /// </summary>
        public static AlimiterFilter AlimiterFilter(this AudioMap audioMap)
          => new AlimiterFilter(audioMap);
    }
}
