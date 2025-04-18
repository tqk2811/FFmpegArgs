/*
drmeter AVOptions:
  length            <double>     ..F.A...... set the window length (from 0.01 to 10) (default 3)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... drmeter           A->A       Measure audio dynamic range.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#drmeter
    /// </summary>
    public class DrmeterFilter : AudioToAudioFilter
    {
        internal DrmeterFilter(AudioMap audioMap) : base("drmeter", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set window length in seconds used to split audio into segments of equal length. (from 0.01 to 10) (default 3)
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public DrmeterFilter Length(double length)
            => this.SetOptionRange("length", length, 0.01, 10);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class DrmeterFilterExtensions
    {
        /// <summary>
        /// Measure audio dynamic range.<br>
        /// </br>DR values of 14 and higher is found in very dynamic material.DR of 8 to 13 is found in transition material.And anything less that 8 have very poor dynamics and is very compressed.
        /// </summary>
        public static DrmeterFilter DrmeterFilter(this AudioMap audioMap)
          => new DrmeterFilter(audioMap);
    }
}
