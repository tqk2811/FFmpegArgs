/*
dcshift AVOptions:
  shift             <double>     ..F.A...... set DC shift (from -1 to 1) (default 0)
  limitergain       <double>     ..F.A...... set limiter gain (from 0 to 1) (default 0)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// T.. dcshift           A->A       Apply a DC shift to the audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#dcshift
    /// </summary>
    public class DcshiftFilter : AudioToAudioFilter, ITimelineSupport
    {
        internal DcshiftFilter(AudioMap audioMap) : base("dcshift", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the DC shift, allowed range is [-1, 1]. It indicates the amount to shift the audio. (default 0)
        /// </summary>
        /// <param name="shift"></param>
        /// <returns></returns>
        public DcshiftFilter SetShift(double shift)
            => this.SetOptionRange("shift", shift, -1, 1);
        /// <summary>
        /// Optional. It should have a value much less than 1 (e.g. 0.05 or 0.02) and is used to prevent clipping. (default 0)
        /// </summary>
        /// <param name="limitergain"></param>
        /// <returns></returns>
        public DcshiftFilter Limitergain(double limitergain)
            => this.SetOptionRange("limitergain", limitergain, 0, 1);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class DcshiftFilterExtensions
    {
        /// <summary>
        /// Apply a DC shift to the audio.<br>
        /// </br>This can be useful to remove a DC offset(caused perhaps by a hardware problem in the recording chain) from the audio.The effect of a DC offset is reduced headroom and hence volume.The <see cref="AstatsFilter"/> filter can be used to determine if a signal has a DC offset.
        /// </summary>
        public static DcshiftFilter DcshiftFilter(this AudioMap audioMap)
          => new DcshiftFilter(audioMap);
    }
}
