/*
aphaseshift AVOptions:
  shift             <double>     ..F.A....T. set phase shift (from -1 to 1) (default 0)
  level             <double>     ..F.A....T. set output level (from 0 to 1) (default 1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC aphaseshift       A->A       Apply phase shifting to input audio.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#aphaseshift"/>
    /// </summary>
    public class AphaseshiftFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AphaseshiftFilter(AudioMap audioMap) : base("aphaseshift", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// set phase shift (from -1 to 1) (default 0)
        /// </summary>
        /// <param name="shift"></param>
        /// <returns></returns>
        public AphaseshiftFilter Shift(double shift)
            => this.SetOptionRange("shift", shift, -1, 1);

        /// <summary>
        /// set output level (from 0 to 1) (default 1)
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AphaseshiftFilter Level(double level)
            => this.SetOptionRange("level", level, 0, 1);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AphaseshiftFilterExtensions
    {
        /// <summary>
        /// Apply phase shift to input audio samples.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#aphaseshift"/>
        /// </summary>
        public static AphaseshiftFilter AphaseshiftFilter(this AudioMap audioMap)
          => new AphaseshiftFilter(audioMap);
    }
}
