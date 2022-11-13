/*
adenorm AVOptions:
  level             <double>     ..F.A....T. set level (from -451 to -90) (default -351)
  type              <int>        ..F.A....T. set type (from 0 to 3) (default dc)
     dc              0            ..F.A....T.
     ac              1            ..F.A....T.
     square          2            ..F.A....T.
     pulse           3            ..F.A....T.
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TSC adenorm           A->A       Remedy denormals by adding extremely low-level noise.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#adenorm"/>
    /// </summary>
    public class AdenormFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AdenormFilter(AudioMap audioMap) : base("adenorm", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set level of added noise in dB. Default is -351. Allowed range is from -451 to -90.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public AdenormFilter Level(double level)
            => this.SetOptionRange("level", level, -451, -90);

        /// <summary>
        /// Set type of added noise. Default dc
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public AdenormFilter Type(AdenormType type)
            => this.SetOption("type", type);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AdenormFilterExtensions
    {
        /// <summary>
        /// Remedy denormals in audio by adding extremely low-level noise.<br>
        /// </br>This filter shall be placed before any filter that can produce denormals.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#adenorm"/>
        /// </summary>
        public static AdenormFilter AdenormFilter(this AudioMap audioMap)
          => new AdenormFilter(audioMap);
    }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AdenormType
    {
        dc,
        ac,
        square,
        pulse,
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
