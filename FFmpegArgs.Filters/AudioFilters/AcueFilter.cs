﻿/*
(a)cue AVOptions:
   cue               <int64>      ..FVA...... cue unix timestamp in microseconds (from 0 to I64_MAX) (default 0)
   preroll           <duration>   ..FVA...... preroll duration in seconds (default 0)
   buffer            <duration>   ..FVA...... buffer duration in seconds (default 0)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... acue              A->A       Delay filtering to match a cue.<br>
    /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#acue"/>
    /// </summary>
    public class AcueFilter : AudioToAudioFilter
    {
        internal AcueFilter(AudioMap audioMap) : base("acue", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// The cue timestamp expressed in a UNIX timestamp in microseconds. Default is 0.
        /// </summary>
        /// <param name="cue"></param>
        /// <returns></returns>
        public AcueFilter Cue(long cue)
          => this.SetOptionRange("cue", cue, 0, I64_MAX);
        /// <summary>
        /// The duration of content to pass on as preroll expressed in seconds. Default is 0.
        /// </summary>
        /// <param name="preroll"></param>
        /// <returns></returns>
        public AcueFilter Preroll(TimeSpan preroll)
          => this.SetOptionRange("preroll", preroll, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// The maximum duration of content to buffer before waiting for the cue expressed in seconds. Default is 0.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public AcueFilter Buffer(TimeSpan buffer)
          => this.SetOptionRange("buffer", buffer, TimeSpan.Zero, TimeSpan.MaxValue);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AcueFilterExtension
    {
        /// <summary>
        /// Delay audio filtering until a given wallclock timestamp. See the <see cref="CueFilter"/>.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#acue"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AcueFilter AcueFilter(this AudioMap audioMap)
            => new AcueFilter(audioMap);
    }
}
