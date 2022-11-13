/*
atrim AVOptions:
  start             <duration>   ..F.A...... Timestamp of the first frame that should be passed (default INT64_MAX)
  starti            <duration>   ..F.A...... Timestamp of the first frame that should be passed (default INT64_MAX)
  end               <duration>   ..F.A...... Timestamp of the first frame that should be dropped again (default INT64_MAX)
  endi              <duration>   ..F.A...... Timestamp of the first frame that should be dropped again (default INT64_MAX)
  start_pts         <int64>      ..F.A...... Timestamp of the first frame that should be  passed (from I64_MIN to I64_MAX) (default I64_MIN)
  end_pts           <int64>      ..F.A...... Timestamp of the first frame that should be dropped again (from I64_MIN to I64_MAX) (default I64_MIN)
  duration          <duration>   ..F.A...... Maximum duration of the output (default 0)
  durationi         <duration>   ..F.A...... Maximum duration of the output (default 0)
  start_sample      <int64>      ..F.A...... Number of the first audio sample that should be passed to the output (from -1 to I64_MAX) (default -1)
  end_sample        <int64>      ..F.A...... Number of the first audio sample that should be dropped again (from 0 to I64_MAX) (default I64_MAX)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... atrim             A->A       Pick one continuous section from the input, drop the rest.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#atrim"/>
    /// </summary>
    public class AtrimFilter : AudioToAudioFilter
    {
        internal AtrimFilter(AudioMap audioMap) : base("atrim", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Timestamp (in seconds) of the start of the section to keep. I.e. the audio sample with the timestamp start will be the first sample in the output.
        /// </summary>
        /// <param name="start">..F.A...... Timestamp of the first frame that should be passed (default INT64_MAX)</param>
        /// <returns></returns>
        public AtrimFilter Start(TimeSpan start)
            => this.SetOptionRange("start", start, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Specify time of the first audio sample that will be dropped, i.e. the audio sample immediately preceding the one with the timestamp end will be the last sample in the output.
        /// </summary>
        /// <param name="end">..F.A...... Timestamp of the first frame that should be dropped again (default INT64_MAX)</param>
        /// <returns></returns>
        public AtrimFilter End(TimeSpan end)
            => this.SetOptionRange("end", end, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Same as start, except this option sets the start timestamp in samples instead of seconds.
        /// </summary>
        /// <param name="start_pts">..F.A...... Timestamp of the first frame that should be  passed (from I64_MIN to I64_MAX) (default I64_MIN)</param>
        /// <returns></returns>
        public AtrimFilter StartPts(long start_pts)
            => this.SetOptionRange("start_pts", start_pts, I64_MIN, I64_MAX);
        /// <summary>
        /// Same as end, except this option sets the end timestamp in samples instead of seconds.
        /// </summary>
        /// <param name="end_pts">..F.A...... Timestamp of the first frame that should be dropped again (from I64_MIN to I64_MAX) (default I64_MIN)</param>
        /// <returns></returns>
        public AtrimFilter EndPts(long end_pts)
           => this.SetOptionRange("end_pts", end_pts, I64_MIN, I64_MAX);
        /// <summary>
        /// The maximum duration of the output in seconds.
        /// </summary>
        /// <param name="duration">..F.A...... Maximum duration of the output (default 0)</param>
        /// <returns></returns>
        public AtrimFilter Duration(TimeSpan duration)
           => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// The number of the first sample that should be output.
        /// </summary>
        /// <param name="start_sample">..F.A...... Number of the first audio sample that should be passed to the output (from -1 to I64_MAX) (default -1)</param>
        /// <returns></returns>
        public AtrimFilter StartSample(long start_sample)
           => this.SetOptionRange("start_sample", start_sample, -1, I64_MAX);
        /// <summary>
        /// The number of the first sample that should be dropped
        /// </summary>
        /// <param name="end_sample">..F.A...... Number of the first audio sample that should be dropped again (from 0 to I64_MAX) (default I64_MAX)</param>
        /// <returns></returns>
        public AtrimFilter EndSample(long end_sample)
           => this.SetOptionRange("end_sample", end_sample, 0, I64_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AtrimFilterExtensions
    {
        /// <summary>
        /// Trim the input so that the output contains one continuous subpart of the input.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#atrim"/>
        /// </summary>
        public static AtrimFilter AtrimFilter(this AudioMap audioMap)
          => new AtrimFilter(audioMap);
    }
}
