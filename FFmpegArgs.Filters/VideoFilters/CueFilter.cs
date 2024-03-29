﻿/*
(a)cue AVOptions:
   cue               <int64>      ..FVA...... cue unix timestamp in microseconds (from 0 to I64_MAX) (default 0)
   preroll           <duration>   ..FVA...... preroll duration in seconds (default 0)
   buffer            <duration>   ..FVA...... buffer duration in seconds (default 0)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... cue               V->V       Delay filtering to match a cue.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#cue-1
    /// </summary>
    public class CueFilter : ImageToImageFilter
    {
        internal CueFilter(ImageMap imageMap) : base("cue", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// The cue timestamp expressed in a UNIX timestamp in microseconds. Default is 0.
        /// </summary>
        /// <param name="cue"></param>
        /// <returns></returns>
        public CueFilter Cue(long cue)
            => this.SetOptionRange("cue", cue, 0, I64_MAX);
        /// <summary>
        /// The duration of content to pass on as preroll expressed in seconds. Default is 0.
        /// </summary>
        /// <param name="preroll"></param>
        /// <returns></returns>
        public CueFilter Preroll(TimeSpan preroll)
            => this.SetOptionRange("preroll", preroll, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// The maximum duration of content to buffer before waiting for the cue expressed in seconds. Default is 0.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public CueFilter Buffer(TimeSpan buffer)
            => this.SetOptionRange("buffer", buffer, TimeSpan.Zero, TimeSpan.MaxValue);
    }
    
    /// <summary>
    /// 
    /// </summary>
    public static class CueFilterExtensions
    {
        /// <summary>
        /// Delay video filtering until a given wallclock timestamp. The filter first passes on preroll amount of frames, then it buffers at most buffer amount of frames and waits for the cue. After reaching the cue it forwards the buffered frames and also any subsequent frames coming in its input.<br></br>
        /// The filter can be used synchronize the output of multiple ffmpeg processes for realtime output devices like decklink.By putting the delay in the filtering chain and pre-buffering frames the process can pass on data to output almost immediately after the target wallclock timestamp is reached.<br></br>
        /// Perfect frame accuracy cannot be guaranteed, but the result is good enough for some use cases.
        /// </summary>
        public static CueFilter CueFilter(this ImageMap imageMap)
          => new CueFilter(imageMap);
    }
}
